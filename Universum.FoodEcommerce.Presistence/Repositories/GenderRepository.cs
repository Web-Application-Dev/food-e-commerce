using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Domain.Entities;
using Universum.FoodEcommerce.Domain.Repositories;

namespace Universum.FoodEcommerce.Presistence.Repositories
{
    public class GenderRepository: IGenderRepository
    {
        private readonly ApplicationDbContext _context;
        public GenderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Gender gender)
        {
            _context.Genders.Add(gender);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Gender gender = _context.Genders.Find(id);
            _context.Genders.Remove(gender);
            _context.SaveChanges();
        }

        public void Edit(int id)
        {
            var gender = _context.Genders.FirstOrDefault(gender => gender.Id == id);
            _context.Genders.Update(gender);
            _context.SaveChanges();
        }

        public List<Gender> GetList()
        {
            return _context.Genders.ToList();
        }

        public Gender GetGenderById(int id)
        {
            return _context.Genders.FirstOrDefault(gender => gender.Id == id);
        }


    }
}
