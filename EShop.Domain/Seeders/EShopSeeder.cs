using EShop.Domain.Models;
using EShop.Domain.Repositories;

namespace EShop.Domain.Seeders
{
    public class EShopSeeder(DataContext context) : IEShopSeeder
    {
        public async Task Seed()
        {
            if (!context.Products.Any())
            {
                var products = new List<Product>
                {
                    new Product { Name = "Coca Cola", ean = "123456789", price = 2.5m, stock = 100, sku = "CC001" },
                    new Product { Name = "Pepsi", ean = "987654321", price = 2.5m, stock = 100, sku = "P001" },
                    new Product
                    {
                        Name = "Dog Plushy", ean = "3123123123123", price = 15.5m, stock = 100,
                        sku = "STP001"
                    },
                };
                
                context.Products.AddRange(products);
                await context.SaveChangesAsync();
            }
            
        }
    }
}
