using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Domain.Entities;

namespace Universum.FoodEcommerce.Application.Interfaces
{
    public interface IOrderService
    {
        bool Register(Order product);
        bool Update(Order product);
        bool Delete(Order product);
        Order GetOrder(int id);
        List<Order> GetOrders();
    }
}
