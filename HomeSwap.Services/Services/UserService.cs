using AutoMapper;
using HomeSwap.Common.DTOs;
using HomeSwap.Repositories.Interfaces;
using HomeSwap.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public Task<UserDTO> AddAsync(int id, int password, string firstName, string lastName, string phone, string mail, int role)
        {
            throw new NotImplementedException();
        }

        public Task Deleteasync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> UpdateAsync(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
