using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universum.FoodEcommerce.Domain.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ZipCode { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
