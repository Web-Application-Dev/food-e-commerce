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
    public class RoleService : IRoleService
    {
        readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public Role GetRole(int id)
        {
            return _roleRepository.GetRole(id);
        }

        public List<Role> GetRoles()
        {
            return _roleRepository.GetRoles();
        }

    }
}
