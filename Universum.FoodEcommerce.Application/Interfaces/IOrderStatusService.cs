using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Domain.Entities;

namespace Universum.FoodEcommerce.Application.Interfaces
{
    public interface IOrderStatusService
    {
        bool Register(OrderStatus product);
        bool Update(OrderStatus product);
        bool Delete(OrderStatus product);
        OrderStatus GetOrderStatus(int id);
        List<OrderStatus> GetOrderStatuses();
    }
}
