using HomeSwap.Repositories.Entities;
using HomeSwap.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Repositories.Repositories
{
    public class UserDetailsRepository : IUserDetailsRepository
    {
        public Task<UserDetails> AddAsync(int userId, EMigzar migzur, EType type, bool status)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDetails>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserDetails> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDetails> UpdateAsync(UserDetails userDetails)
        {
            throw new NotImplementedException();
        }
    }
}
