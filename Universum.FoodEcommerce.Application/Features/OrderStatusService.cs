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
    public class OrderStatusService : IOrderStatusService
    {
        

        readonly IOrderStatusrepository _orderStatusRepository;
        public OrderStatusService(IOrderStatusrepository orderStatusRepository)
        {
            _orderStatusRepository = orderStatusRepository;
        }
        public bool Delete(OrderStatus product)
        {
            return true;
        }

        public OrderStatus GetOrderStatus(int id)
        {
            return _orderStatusRepository.GetOrderStatus(id);
        }

        public List<OrderStatus> GetOrderStatuses()
        {
            return _orderStatusRepository.GetOrderStatuses();
        }

        public bool Register(OrderStatus product)
        {
            return true;
        }

        public bool Update(OrderStatus product)
        {
            return true;
        }
    }
}
