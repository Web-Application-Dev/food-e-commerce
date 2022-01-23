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
    public class ProductTypeRepository : IProductTypeRepository
    {
        private readonly ApplicationDbContext _context;
        ILogger<PhotoRepository> _logger;
        public ProductTypeRepository(ApplicationDbContext context, ILogger<PhotoRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public bool Delete(ProductType productType)
        {
            throw new NotImplementedException();
        }

        public ProductType GetProductType(int id)
        {
            return _context.ProductTypes.FirstOrDefault(productType => productType.Id == id);
        }

        public List<ProductType> GetProductTypes()
        {
            return _context.ProductTypes.ToList();
        }

        public bool Register(ProductType productType)
        {
            try
            {
                _context.ProductTypes.Add(productType);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred with message: " + ex.Message);
                return false;
            }
        }

        public bool Update(ProductType productType)
        {
            try
            {
                _context.Entry(productType).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
