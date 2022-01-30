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
    public class PhotoService : IPhotoService
    {
        
        readonly IPhotoRepository _photoRepository;
        public PhotoService(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }
        public bool Delete(Photo product)
        {
            return true;
        }

        public Photo GetPhoto(int id)
        {
            return _photoRepository.GetPhoto(id);
        }

        public List<Photo> GetPhotos()
        {
            return _photoRepository.GetPhotos();
        }

        public bool Register(Photo product)
        {
            return true;
        }

        public bool Update(Photo product)
        {
            return true;
        }
    }
}
