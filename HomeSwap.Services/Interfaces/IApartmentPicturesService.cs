using HomeSwap.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Services.Interfaces
{
    public interface IApartmentPicturesService
    {
        public Task<List<ApartmentPicturesDTO>> GetAllAsync();
        public Task<ApartmentPicturesDTO> AddAsync(int id, int apartmentId, string picture);
        public Task<ApartmentPicturesDTO> UpdateAsync(ApartmentPicturesDTO apartmentPictures);
        public Task DeleteAsync(int id);
        Task<ApartmentPicturesDTO> GetByIdAsync(int id);
    }
}
