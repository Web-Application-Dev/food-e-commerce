using System.Collections.Generic;
using Universum.FoodEcommerce.Domain.Entities;

namespace Universum.FoodEcommerce.Domain.Repositories
{
    public interface ICityRepository
    {
        City GetByZipCode(string zipcode);
        IList<City> GetByStateId(int stateId);
    }
}
