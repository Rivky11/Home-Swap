using AutoMapper;
using HomeSwap.Repositories.Entities;
using HomeSwap.Repositories.Interfaces;
using HomeSwap.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Services.Services
{
    public class ApartmentService : IApartmentService
    {
        private readonly IApartmentRepository _apartmentRepository;
        private readonly IMapper _mapper;

        public ApartmentService(IApartmentRepository apartmentRepository, IMapper mapper)
        {
            _apartmentRepository = apartmentRepository;
            _mapper = mapper;
        }

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
