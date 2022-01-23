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
    public class OrderStatusRepository : IOrderStatusrepository
    {
        private readonly ApplicationDbContext _context;
        ILogger<OrderStatusRepository> _logger;
        public OrderStatusRepository(ApplicationDbContext context, ILogger<OrderStatusRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public bool Delete(OrderStatus orderStatus)
        {
            try
            {
                _context.OrderStatuses.Remove(orderStatus);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred with message: " + ex.Message);
                return false;
            }
        }

        public OrderStatus GetOrderStatus(int id)
        {
            return _context.OrderStatuses.FirstOrDefault(orderStatus => orderStatus.Id == id);
        }

        public List<OrderStatus> GetOrderStatuses()
        {
            return _context.OrderStatuses.ToList();
        }

        public bool Register(OrderStatus orderStatus)
        {
            try
            {
                _context.OrderStatuses.Add(orderStatus);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred with message: " + ex.Message);
                return false;
            }
        }

        public bool Update(OrderStatus orderStatus)
        {
            try
            {
                _context.Entry(orderStatus).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
