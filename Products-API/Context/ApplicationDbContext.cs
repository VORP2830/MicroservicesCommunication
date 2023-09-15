using Microsoft.EntityFrameworkCore;
using Products_API.Entities;

namespace Products_API.Context
{
    public class ApplicationDbContext : DbContext
    {
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }  
      public DbSet<Product> Products { get; set; }
      public DbSet<Category> Categories { get; set; }
      public DbSet<Supplier> Suppliers { get; set; }
    }
}