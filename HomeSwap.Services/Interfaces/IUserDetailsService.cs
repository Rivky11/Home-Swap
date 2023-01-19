using HomeSwap.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Services.Interfaces
{
    public interface IUserDetailsService
    {
        public Task<List<UserDetailsDTO>> GetAllAsync();
        public Task<UserDetailsDTO> GetByIdAsync(int id);
        public Task<UserDetailsDTO> AddAsync(int userId, EMigzarDTO migzur, ETypeDTO type, bool status);
        public Task<UserDetailsDTO> UpdateAsync(UserDetailsDTO userDetails);
        public Task DeleteAsync(int id);
    }
}
