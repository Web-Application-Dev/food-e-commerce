using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Domain.Entities;

namespace Universum.FoodEcommerce.Application.Interfaces
{
   public  interface ICityService
    {
        City GetByZipCode(string zipcode);
        IList<City> GetByStateId(int stateId);
    }
}
