using HomeSwap.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Services.Interfaces
{
    public interface IUserService
    {
        public Task<List<User>> GetAllAsync();
        public Task<User> GetByIdAsync(int id);
        public Task<User> AddAsync(int id, int password, string firstName, string lastName, string phone, string mail, int role);
        public Task<User> UpdateAsync(User user);
        public Task Deleteasync(int id);
    }
}
