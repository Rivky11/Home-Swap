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
    public class ApartmentRatingService : IApartmentRatingService
    {

        private readonly IApartmentRatingRepository _apartmentRatingRepository;
        private readonly IMapper _mapper;

        public ApartmentRatingService(IApartmentRatingRepository apartmentRatingRepository, IMapper mapper)
        {
            _apartmentRatingRepository = apartmentRatingRepository;
            _mapper = mapper;
        }

        public Task<ApartmentPictures> AddAsync(int id, int guessId, int apartmentId, int clean, string discreption)
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
