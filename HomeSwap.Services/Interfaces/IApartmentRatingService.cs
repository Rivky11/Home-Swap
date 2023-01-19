using HomeSwap.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Services.Interfaces
{
    public interface IApartmentRatingService
    {
        public Task<List<ApartmentRatingDTO>> GetAllAsync();
        public Task<ApartmentRatingDTO> GetByIdAsync(int id);
        public Task<ApartmentRatingDTO> AddAsync(int id, int guessId, int apartmentId, int clean, string discreption);
        public Task<ApartmentRatingDTO> UpdateAsync(ApartmentRatingDTO apartmentPictures);
        public Task DeleteAsync(int id);
    }
}
