using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>().HasData(
            new List<Product> {
                new Product { ProductId=1, ProductName="IPhone 16 Pro", Description="Telefon açıklaması.", ImageUrl="1.png", ProductPrice = 87999, IsActive=true, Stock=50 },
                new Product { ProductId=2, ProductName="IPhone 11 Pro Max", Description="Telefon açıklaması2.", ImageUrl="2.png", ProductPrice = 41000, IsActive=true, Stock=15 },
                new Product { ProductId=3, ProductName="Poco", Description="Telefon açıklaması3.", ImageUrl="3.png", ProductPrice = 21000, IsActive=true, Stock=50 },
                new Product { ProductId=4, ProductName="Samsung Galaxy S24", Description="Telefon açıklaması4.", ImageUrl="4.png", ProductPrice = 45000, IsActive=true, Stock=40 },
                new Product { ProductId=5, ProductName="IPhone 15 Pro", Description="Telefon açıklaması5.", ImageUrl="5.png", ProductPrice = 99999, IsActive=true, Stock=50 }
            }
        );
    }

    public DbSet<Product> Products { get; set; }
}