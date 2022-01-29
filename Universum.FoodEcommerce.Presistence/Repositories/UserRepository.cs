using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Domain.DTO;
using Universum.FoodEcommerce.Domain.Entities;
using Universum.FoodEcommerce.Domain.Repositories;

namespace Universum.FoodEcommerce.Presistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        ILogger<PhotoRepository> _logger;
        public UserRepository(ApplicationDbContext context, ILogger<PhotoRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public bool LogIn(UserLogInDTO userLogIn)
        {
            throw new NotImplementedException();
        }

        public bool Register(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred with message: " + ex.Message);
                return false;
            }
        }

        public bool Update(User user)
        {
            try
            {
                _context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred with message: " + ex.Message);
                return false;
            }
        }

        public bool Delete(User user)
        {
            try
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred with message: " + ex.Message);
                return false;
            }
        }

        public bool VerifyLogIn()
        {
            throw new NotImplementedException();
        }
    }
}
