using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Domain.Entities;
using Universum.FoodEcommerce.Domain.Repositories;

namespace Universum.FoodEcommerce.Presistence.Repositories
{
    public class AddressRepository: IAddressRepository
    {
        private readonly ApplicationDbContext _context;
        public AddressRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Address address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Address address = _context.Addresses.Find(id);
            _context.Addresses.Remove(address);
            _context.SaveChanges();
        }

        public void Edit(int id)
        {
            var address = _context.Addresses.FirstOrDefault(address => address.Id == id);
            _context.Addresses.Update(address);
            _context.SaveChanges();
        }

        public List<Address> GetAll()
        {
            return _context.Addresses.ToList();
        }

        public Address GetById(int id)
        {
            return _context.Addresses.FirstOrDefault(address => address.Id == id);
        }
    }
}
