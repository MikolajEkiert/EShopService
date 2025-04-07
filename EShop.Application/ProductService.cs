
using EShop.Domain.Models;
using EShop.Domain.Repositories;

namespace Eshop.Application
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Product GetProduct(int id)
        {
            return _productRepository.GetById(id);
        }
        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetAllProducts();
        }
        public void AddProduct(Product product) { 
            _productRepository.Add(product);
        }
        public bool DeleteProduct(int id)
        {
            return _productRepository.Delete(id);
        }
        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
        }
      
    }
}