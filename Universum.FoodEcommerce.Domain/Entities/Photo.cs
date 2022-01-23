using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universum.FoodEcommerce.Domain.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public string PhotoURL { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
