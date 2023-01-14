using HomeSwap.Repositories.Entities;
using HomeSwap.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Repositories.Repositories
{
    public class ApartmentPicturesRepository : IApartmentPicturesRepository
    {

        private readonly IContext _context;

        public ApartmentPicturesRepository(IContext context)
        {
            _context = context;
        }

        public async Task<ApartmentPictures> AddAsync(int id, int apartmentId, string picture)
        {
            ApartmentPictures apartmentPictures = new ApartmentPictures(id, apartmentId, picture);
            _context.ApartmentPictures.Add(apartmentPictures);
            await _context.SaveChangesAsync();
            return apartmentPictures;
        }


        public async Task DeleteAsync(int id)
        {
            _context.ApartmentPictures.Remove(GetById(id));
            await _context.SaveChangesAsync();
        }



        public Task<List<ApartmentPictures>> GetAllAsync()
        {
            return _context.ApartmentPictures.ToListAsync();
        }

        public ApartmentPictures GetById(int id)
        {
            return _context.ApartmentPictures.First(item => item.Id == id);
        }

        public async Task<ApartmentPictures> GetByIdAsync(int id)
        {
            return await _context.ApartmentPictures.FindAsync(id);
        }


        public async Task<ApartmentPictures> UpdateAsync(ApartmentPictures toUpdate)
        {
            var apartmentPictures = GetById(toUpdate.Id);
            apartmentPictures.ApartmentId = toUpdate.ApartmentId;
            apartmentPictures.Picture = toUpdate.Picture;
            await _context.SaveChangesAsync();
            return apartmentPictures;

        }
    }
}
