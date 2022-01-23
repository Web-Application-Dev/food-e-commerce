using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universum.FoodEcommerce.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
