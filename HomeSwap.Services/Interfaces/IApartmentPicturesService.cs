using HomeSwap.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Services.Interfaces
{
    public interface IApartmentPicturesService
    {
        public Task<List<ApartmentPictures>> GetAllAsync();
        public Task<ApartmentPictures> GetByIdAsync(int id);
        public Task<ApartmentPictures> AddAsync(int id, int apartmentId, string picture);
        public Task<ApartmentPictures> UpdateAsync(ApartmentPictures apartmentPictures);
        public Task DeleteAsync(int id);
    }
}
