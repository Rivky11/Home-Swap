using AutoMapper;
using HomeSwap.Common.DTOs;
using HomeSwap.Repositories.Entities;
using HomeSwap.Repositories.Interfaces;
using HomeSwap.Repositories.Repositories;
using HomeSwap.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Services.Services
{
    public class AdvertisedApartmentService : IAdveretisedApartmentService
    {
        private readonly IAdveretisedApartmentRepository _adveretisedApartmentRepository;
        private readonly IMapper _mapper;

        public AdvertisedApartmentService(IAdveretisedApartmentRepository adveretisedApartmentRepository, IMapper mapper)
        {
            _adveretisedApartmentRepository = adveretisedApartmentRepository;
            _mapper = mapper;
        }
        public async Task<AdveretisedApartment> AddAsync(int id, int apartmentId, DateTime dateAdd, DateTime fromDate, DateTime toDate, bool status)
        {
            return _mapper.Map<AdveretisedApartmentDTO>(await _adveretisedApartmentRepository.AddAsync(id, apartmentId, dateAdd, fromDate, toDate,status));
        }

        public async Task DeleteAsync(int id)
        {
            await _adveretisedApartmentRepository.DeleteAsync(id);
        }

        public async Task<List<AdveretisedApartment>> GetAllAsync()
        {
           return  _mapper.Map<List<AdveretisedApartmentDTO>>(await _adveretisedApartmentRepository.GetAllAsync());

        }

        public async Task<AdveretisedApartment> GetByIdAsync(int id)
        {
            return _mapper.Map<AdveretisedApartmentDTO>(await _adveretisedApartmentRepository.GetByIdAsync(id));
        }

        public async Task<AdveretisedApartment> UpdateAsync(AdveretisedApartment adveretisedApartment)
        {
            return _mapper.Map<AdveretisedApartmentDTO>(await _adveretisedApartmentRepository.UpdateAsync(adveretisedApartment));
        }
    }
}
