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
    public class PhotoRepository : IPhotoRepository
    {
        private readonly ApplicationDbContext _context;
        ILogger<PhotoRepository> _logger;
        public PhotoRepository(ApplicationDbContext context, ILogger<PhotoRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public bool Delete(Photo photo)
        {
            try
            {
                _context.Photos.Remove(photo);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred with message: " + ex.Message);
                return false;
            }
        }

        public Photo GetPhoto(int id)
        {
            return _context.Photos.FirstOrDefault(photo => photo.Id == id);
        }

        public List<Photo> GetPhotos()
        {
            return _context.Photos.ToList();
        }

        public bool Register(Photo photo)
        {
            try
            {
                _context.Photos.Add(photo);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred with message: " + ex.Message);
                return false;
            }
        }

        public bool Update(Photo photo)
        {
            try
            {
                _context.Entry(photo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred with message: " + ex.Message);
                return false;
            }
        }
    }
}
