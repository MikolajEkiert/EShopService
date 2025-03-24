using EShop.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EShop.Domain.Repositories
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        
        public DbSet<Category> Categories { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseInMemoryDatabase("Products");
        }
        
    }
    
  
}