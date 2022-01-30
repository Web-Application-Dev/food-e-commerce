using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Application.Interfaces;
using Universum.FoodEcommerce.Domain.DTO;
using Universum.FoodEcommerce.Domain.Entities;
using Universum.FoodEcommerce.Domain.Repositories;

namespace Universum.FoodEcommerce.Application.Features
{
    public class UserService : IUserService
    {
        readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool LogIn(UserLogInDTO userLogIn)
        {
            return true;
        }

        public bool Register(User user)
        {
            return true;
        }

        public bool Update(User user)
        {
            return true;
        }

        public bool VerifyLogIn()
        {
            return true;
        }
    }
}
