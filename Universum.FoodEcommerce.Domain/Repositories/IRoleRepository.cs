using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Domain.Entities;

namespace Universum.FoodEcommerce.Domain.Repositories
{
    public interface IRoleRepository
    {
        Role GetRole(int id);
        List<Role> GetRoles();
    }
}
