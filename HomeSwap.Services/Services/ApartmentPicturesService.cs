using AutoMapper;
using HomeSwap.Common.DTOs;
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
    public class ApartmentPicturesService : IApartmentPicturesService
    {
        private readonly IApartmentPicturesRepository _apartmentPicturesDTOtRepository ;
        private readonly IMapper _mapper;

        public ApartmentPicturesService(IApartmentPicturesRepository apartmentPicturesDTOtRepository, IMapper mapper)
        {
            _apartmentPicturesDTOtRepository = apartmentPicturesDTOtRepository;
            _mapper = mapper;
        }

        public Task<ApartmentPicturesDTO> AddAsync(int id, int apartmentId, string picture)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ApartmentPicturesDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ApartmentPicturesDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApartmentPicturesDTO> UpdateAsync(ApartmentPicturesDTO apartmentPicturesDTO)
        {
            throw new NotImplementedException();
        }
    }
}
