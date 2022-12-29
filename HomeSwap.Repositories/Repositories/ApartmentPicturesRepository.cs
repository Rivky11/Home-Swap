using HomeSwap.Repositories.Entities;
using HomeSwap.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Repositories.Repositories
{
    public class ApartmentPicturesRepository : IApartmentPicturesRepository
    {
        public Task<ApartmentPictures> AddAsync(int id, int apartmentId, string picture)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ApartmentPictures>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ApartmentPictures> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApartmentPictures> UpdateAsync(ApartmentPictures apartmentPictures)
        {
            throw new NotImplementedException();
        }
    }
}
