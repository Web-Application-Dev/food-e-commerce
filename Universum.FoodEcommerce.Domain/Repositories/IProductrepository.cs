using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Domain.Entities;

namespace Universum.FoodEcommerce.Domain.Repositories
{
    public interface IProductRepository
    {
        bool Register(Product product);
        bool Update(Product product);
        bool Delete(Product product);
        Product GetProduct(int id);
        List<Product> GetProducts();
    }
}
