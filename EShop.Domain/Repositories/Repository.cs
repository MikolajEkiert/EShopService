using EShop.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace  EShop.Domain.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        bool Delete(int id);
    }

    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        
        public void Add(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
        }
        
        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.Find(id) ?? throw new KeyNotFoundException($"Product with ID {id} not found.");
        }
        
        public bool Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null) {
                _context.Remove(product);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        
        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}