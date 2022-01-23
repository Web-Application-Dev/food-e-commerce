using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Domain.Entities;
using Universum.FoodEcommerce.Domain.Repositories;

namespace Universum.FoodEcommerce.Presistence.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly ApplicationDbContext _context;
       
        public CityRepository(ApplicationDbContext context)
        {
            _context = context;
            
        }

        public void Add(City city)
        {
            _context.Cities.Add(city);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            City city = _context.Cities.Find(id);
            _context.Cities.Remove(city);
            _context.SaveChanges();


        }

        public void Edit(int id)
        {
            var city = _context.Cities.FirstOrDefault(city => city.Id == id);
            _context.Cities.Update(city);
            _context.SaveChanges();
        }

        public List<City> GetAll()
        {
            return _context.Cities.ToList();
        }

        public List<City> GetByCountryId(int countryId)
        {
            return _context.Cities.Where(city => city.StateId == countryId).ToList();
        }

        public City GetById(int id)
        {
            return _context.Cities.FirstOrDefault(city => city.Id == id);
        }

        public IList<City> GetByStateId(int stateId)
        {
            return _context.Cities.Where(x => x.StateId == stateId).ToList();
        }

        public City GetByZipCode(string zipCode)
        {
            return _context.Cities.FirstOrDefault(city => city.ZipCode == zipCode);
        }
    }
}
