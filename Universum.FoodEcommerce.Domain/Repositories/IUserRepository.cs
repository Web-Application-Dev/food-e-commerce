using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Domain.DTO;
using Universum.FoodEcommerce.Domain.Entities;

namespace Universum.FoodEcommerce.Domain.Repositories
{
    public interface IUserRepository
    {
        bool Register(User user);
        bool Update(User user);
        bool LogIn(UserLogInDTO userLogIn);
        bool VerifyLogIn();
    }
}
