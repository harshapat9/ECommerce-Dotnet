
using ECommerce.Database;
using Microsoft.EntityFrameworkCore;

namespace LMS.Database.ContextNamespace;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }    
    public DbSet<UserInformation> UserInformations { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
            .HasOne(c => c.Cart)
            .WithOne(c => c.Customer)
            .OnDelete(DeleteBehavior.Cascade);
    }
}