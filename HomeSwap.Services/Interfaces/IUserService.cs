using HomeSwap.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Services.Interfaces
{
    public interface IUserService
    {
        public Task<List<UserDTO>> GetAllAsync();
        public Task<UserDTO> GetByIdAsync(int id);
        public Task<UserDTO> AddAsync(int id, int password, string firstName, string lastName, string phone, string mail, int role);
        public Task<UserDTO> UpdateAsync(UserDTO user);
        public Task Deleteasync(int id);
        Task<UserDTO> GetUserByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}
