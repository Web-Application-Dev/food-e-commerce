using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Domain.Entities;

namespace Universum.FoodEcommerce.Application.Interfaces
{
    public interface IProductTypeService
    {
        bool Register(ProductType product);
        bool Update(ProductType product);
        bool Delete(ProductType product);
        ProductType GetProductType(int id);
        List<ProductType> GetProductTypes();
    }
}
