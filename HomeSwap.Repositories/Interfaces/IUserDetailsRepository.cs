using HomeSwap.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Repositories.Interfaces
{
    public interface IUserDetailsRepository
    {
        public Task<List<UserDetails>> GetAllAsync();
        public Task<UserDetails> GetByIdAsync(int id);
        public Task<UserDetails> AddAsync(int userId, EMigzar migzur, EType type, bool status);
        public Task<UserDetails> UpdateAsync(UserDetails userDetails);
        public Task DeleteAsync(int id);
    }
}
