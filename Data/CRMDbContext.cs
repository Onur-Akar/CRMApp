using CRMApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CRMApp.Data;

public class CRMDbContext : DbContext
{
    public CRMDbContext(DbContextOptions<CRMDbContext> options) : base(options) { }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
