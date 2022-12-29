using HomeSwap.Repositories.Entities;
using HomeSwap.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Repositories.Repositories
{
    public class ApartmentRepository : IApartmentRepository
    {
        public Task<Apartment> AddAsync(int id, int userId, string city, string adress, int numBeds, int numRooms, int area, int floor, bool isConditioned, bool isMMD, bool isAccessForDisabled, bool isElevator, bool isKosherKitchen, bool isRenovated, bool isBars, bool isForSleepingOnly)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Apartment>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Apartment> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Apartment> UpdateAsync(Apartment apartment)
        {
            throw new NotImplementedException();
        }
    }
}
