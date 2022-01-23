using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Domain.Entities;
using Universum.FoodEcommerce.Domain.Repositories;

namespace Universum.FoodEcommerce.Presistence.Repositories
{
    public class ProductRepository : IProductrepository
    {
        private readonly ApplicationDbContext _context;
        ILogger<PhotoRepository> _logger;
        public ProductRepository(ApplicationDbContext context, ILogger<PhotoRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public bool Delete(Product product)
        {
            try
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred with message: " + ex.Message);
                return false;
            }
        }

        public Product GetProduct(int id)
        {
            return _context.Products.FirstOrDefault(product => product.Id == id);
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public bool Register(Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred with message: " + ex.Message);
                return false;
            }
        }

        public bool Update(Product product)
        {
            try
            {
                _context.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred with message: " + ex.Message);
                return false;
            }
        }
    }
}
