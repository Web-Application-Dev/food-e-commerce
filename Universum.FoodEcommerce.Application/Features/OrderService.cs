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
    public class OrderService : IOrderService
    {
       

        readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public bool Delete(Order product)
        {
            return true;
        }

        public Order GetOrder(int id)
        {
            return _orderRepository.GetOrder(id);
        }

        public List<Order> GetOrders()
        {
            return _orderRepository.GetOrders();
        }

        public bool Register(Order product)
        {
            return true;
        }

        public bool Update(Order product)
        {
            return true;
        }
    }
}
