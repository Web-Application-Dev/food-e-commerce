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
    public class CityService : ICityService
    {
        readonly ICityRepository _cityRepository;
        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        public IList<City> GetByStateId(int stateId)
        {
            return _cityRepository.GetByStateId(stateId);
        }

        public City GetByZipCode(string zipcode)
        {
            return _cityRepository.GetByZipCode(zipcode);
        }
    }
}
