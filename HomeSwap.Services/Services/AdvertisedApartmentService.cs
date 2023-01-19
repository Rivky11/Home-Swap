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
        public async Task<AdveretisedApartmentDTO> AddAsync(int id, int apartmentId, DateTime dateAdd, DateTime fromDate, DateTime toDate, bool status)
        {
            return _mapper.Map<AdveretisedApartmentDTO>(await _adveretisedApartmentRepository.AddAsync(id, apartmentId, dateAdd, fromDate, toDate, status));
        }

        public async Task DeleteAsync(int id)
        {
            await _adveretisedApartmentRepository.DeleteAsync(id);
        }

        public async Task<List<AdveretisedApartmentDTO>> GetAllAsync()
        {
           return  _mapper.Map<List<AdveretisedApartmentDTO>>(await _adveretisedApartmentRepository.GetAllAsync());

        }

        public async Task<AdveretisedApartmentDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<AdveretisedApartmentDTO>(await _adveretisedApartmentRepository.GetByIdAsync(id));
        }

        public async Task<AdveretisedApartmentDTO> UpdateAsync(AdveretisedApartmentDTO adveretisedApartment)
        {
            return _mapper.Map<AdveretisedApartmentDTO>(await _adveretisedApartmentRepository.UpdateAsync(_mapper.Map<AdveretisedApartment>(adveretisedApartment)));
        }
    }
}
