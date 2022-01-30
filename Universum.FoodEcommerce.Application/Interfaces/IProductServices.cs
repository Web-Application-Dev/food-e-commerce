using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Domain.Entities;

namespace Universum.FoodEcommerce.Application.Interfaces
{
    public interface IProductServices
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        bool Add(Product dto);
    }
}
