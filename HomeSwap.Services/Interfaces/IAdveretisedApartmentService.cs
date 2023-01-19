
using HomeSwap.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Services.Interfaces
{
    public interface IAdveretisedApartmentService
    {
        public Task<List<AdveretisedApartmentDTO>> GetAllAsync();
        public Task<AdveretisedApartmentDTO> GetByIdAsync(int id);
        public Task<AdveretisedApartmentDTO> AddAsync(int id, int apartmentId, DateTime dateAdd, DateTime fromDate, DateTime toDate, bool status);
        public Task<AdveretisedApartmentDTO> UpdateAsync(AdveretisedApartmentDTO adveretisedApartment);
        public Task DeleteAsync(int id);
    }
}
