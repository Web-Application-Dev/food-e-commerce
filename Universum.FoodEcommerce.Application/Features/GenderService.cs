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
    public class GenderService : IGenderService
    {
        readonly IGenderRepository _genderRepository;
        public GenderService(IGenderRepository genderRepository)
        {
            _genderRepository = genderRepository;
        }
        public Gender GetGenderById(int genderId)
        {
            return _genderRepository.GetGenderById(genderId);
        }

        public List<Gender> GetList()
        {
            return _genderRepository.GetList();
        }
    }
}
