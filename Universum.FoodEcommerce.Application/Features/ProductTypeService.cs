using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Application.Interfaces;
using Universum.FoodEcommerce.Domain.Entities;
using Universum.FoodEcommerce.Domain.Repositories;

namespace Universum.FoodEcommerce.Application.Features
{
    public class ProductTypeService : IProductTypeService
    {
        readonly IProductTypeRepository _productTypeRepository;
        public ProductTypeService(IProductTypeRepository productTypeRepository)
        {
            _productTypeRepository = productTypeRepository;
        }
        public bool Delete(ProductType product)
        {
            return true;
        }

        public ProductType GetProductType(int id)
        {
            return _productTypeRepository.GetProductType(id);
        }

        public List<ProductType> GetProductTypes()
        {
            return _productTypeRepository.GetProductTypes();
        }

        public bool Register(ProductType product)
        {
            return true;
        }

        public bool Update(ProductType product)
        {
            return true;
        }
    }
}
