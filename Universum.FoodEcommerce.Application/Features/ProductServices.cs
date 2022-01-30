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
    public class ProductServices : IProductServices
    {
        readonly IProductRepository _productRepository;
        public ProductServices(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public bool Add(Product dto)
        {
            _productRepository.Register(dto);
            return true;
        }

        public List<Product> GetAllProducts()
        {
           return  _productRepository.GetProducts();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetProduct(id);
        }
    }
}
