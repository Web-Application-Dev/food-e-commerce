using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Domain.Entities;
using Universum.FoodEcommerce.Domain.Repositories;

namespace Universum.FoodEcommerce.Presistence.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;
        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Role GetRole(int id)
        {
            return _context.Roles.FirstOrDefault(role => role.Id == id);
        }

        public List<Role> GetRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
