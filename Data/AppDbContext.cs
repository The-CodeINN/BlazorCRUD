using BlazorFluentCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorFluentCRUD.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {
        
    }

    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(
            new Customer {
                Id = 1,
                Name = "John Doe",
                Email = "johndoe@gmail.com",
            },
            new Customer {
                Id = 2,
                Name = "Jane Doe",
                Email = "janedoe@gmail.com",
            }
        );
        base.OnModelCreating(modelBuilder);
    }
}
