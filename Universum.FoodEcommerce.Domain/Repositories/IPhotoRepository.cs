using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Domain.Entities;

namespace Universum.FoodEcommerce.Domain.Repositories
{
    public interface  IPhotoRepository
    {
        bool Register(Photo product);
        bool Update(Photo product);
        bool Delete(Photo product);
        Photo GetPhoto(int id);
        List<Photo> GetPhotos();
    }
}
