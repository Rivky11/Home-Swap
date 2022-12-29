using HomeSwap.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Repositories.Interfaces
{
    public interface IApartmentRatingRepository
    {
        public Task<List<ApartmentPictures>> GetAllAsync();
        public Task<ApartmentPictures> GetByIdAsync(int id);
        public Task<ApartmentPictures> AddAsync(int id, int guessId ,int apartmentId ,int clean , string discreption);
        public Task<ApartmentPictures> UpdateAsync(ApartmentPictures apartmentPictures);
        public Task DeleteAsync(int id);

    }
}
