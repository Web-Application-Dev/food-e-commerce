using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universum.FoodEcommerce.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public ICollection<Order> Orders{ get; set; }

    }
}
