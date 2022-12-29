using HomeSwap.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Services.Interfaces
{
    public interface IApartmentService
    {
        public Task<List<Apartment>> GetAllAsync();
        public Task<Apartment> GetByIdAsync(int id);
        public Task<Apartment> AddAsync(int id, int userId, string city, string adress, int numBeds, int numRooms, int area, int floor,
                              bool isConditioned, bool isMMD, bool isAccessForDisabled, bool isElevator, bool isKosherKitchen, bool isRenovated, bool isBars, bool isForSleepingOnly);
        public Task<Apartment> UpdateAsync(Apartment apartment);
        public Task DeleteAsync(int id);
    }
}
