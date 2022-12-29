using HomeSwap.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Repositories.Interfaces
{
    public interface IAdveretisedApartmentRepository
    {
        public Task <List<AdveretisedApartment>> GetAllAsync();
        public Task <AdveretisedApartment> GetByIdAsync(int id);
        public Task<AdveretisedApartment> AddAsync(int id, int apartmentId, DateTime dateAdd, DateTime fromDate, DateTime toDate, bool status);
        public Task<AdveretisedApartment> UpdateAsync(AdveretisedApartment adveretisedApartment);
        public Task DeleteAsync(int id);

    }
}
