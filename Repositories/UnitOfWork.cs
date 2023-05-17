using CRMApp.Models;
using CRMApp.Data;
using Microsoft.EntityFrameworkCore;

namespace CRMApp.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly CRMDbContext _context;
    private readonly IRepository<Customer> _customerRepository;
    private readonly IRepository<Order> _orderRepository;


    public UnitOfWork(CRMDbContext context, IRepository<Customer> customerRepository, IRepository<Order> orderRepository)
    {
        _context = context;
        _customerRepository = customerRepository;
        _orderRepository = orderRepository;
    }

    public IRepository<Customer> CustomerRepository => _customerRepository;
    public IRepository<Order> OrderRepository => _orderRepository;

    public async Task<int> CommitAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Rollback()
    {
        // Rollback işlemi için gerekli kodlar buraya eklenecek

        var changedEntries = _context.ChangeTracker.Entries()
        .Where(e => e.State != EntityState.Unchanged)
        .ToList();

        foreach (var entry in changedEntries)
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.State = EntityState.Detached;
                    break;

                case EntityState.Modified:
                case EntityState.Deleted:
                    entry.Reload();
                    break;
            }
        }

        _context.Dispose();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
