using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universum.FoodEcommerce.Domain.Entities
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public City City { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
