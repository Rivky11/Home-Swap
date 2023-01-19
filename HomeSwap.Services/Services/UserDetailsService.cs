using AutoMapper;
using HomeSwap.Common.DTOs;
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
    public class UserDetailsService : IUserDetailsService
    {
        private readonly IUserDetailsRepository _userDetailsRepository;
        private readonly IMapper _mapper;

        public UserDetailsService(IUserDetailsRepository userDetailsRepository, IMapper mapper)
        {
            _userDetailsRepository = userDetailsRepository;
            _mapper = mapper;
        }


        public Task<UserDetailsDTO> AddAsync(int userId, EMigzarDTO migzur, ETypeDTO type, bool status)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDetailsDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserDetailsDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDetailsDTO> UpdateAsync(UserDetailsDTO userDetails)
        {
            throw new NotImplementedException();
        }
    }
}
