using CRMApp.Models;
using CRMApp.Data;namespace CRMApp.Repositories;

public class CustomerRepository : IRepository<Customer>
{
    private readonly CRMDbContext _context;
    public CustomerRepository(CRMDbContext context) => _context = context;
    public Task AddAsync(Customer entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Customer entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Customer>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Customer> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Customer entity)
    {
        throw new NotImplementedException();
    }
}
