using EShop.Domain.Models;

namespace Eshop.Application
{
    public interface IProductService
    {
        public Product GetProduct(int id);
        public bool DeleteProduct(int id);
        public void UpdateProduct(Product product);
        public IEnumerable<Product> GetProducts();
        public void AddProduct(Product product);
    }
}