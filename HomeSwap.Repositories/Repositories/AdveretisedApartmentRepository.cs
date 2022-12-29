using HomeSwap.Repositories.Entities;
using HomeSwap.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Repositories.Repositories
{
    public class AdveretisedApartmentRepository : IAdveretisedApartmentRepository
    {
        private readonly IContext _context;

        public AdveretisedApartmentRepository(IContext context)
        {
            _context = context;
        }
    
        public async Task<AdveretisedApartment> AddAsync(int id, int apartmentId, DateTime dateAdd, DateTime fromDate, DateTime toDate, bool status)
        {
            AdveretisedApartment adveretisedApartment = new AdveretisedApartment(id, apartmentId, dateAdd, fromDate, toDate, status);
            _context.AdveretisedApartments.Add(adveretisedApartment);   
            await _context.SaveChangesAsync();
            return adveretisedApartment;
        }


        public async Task DeleteAsync(int id)
        {
            _context.AdveretisedApartments.Remove(GetById(id));
            await _context.SaveChangesAsync();
        }



        public Task<List<AdveretisedApartment>> GetAllAsync()
        {
            return _context.AdveretisedApartments.ToListAsync();
        }

        public AdveretisedApartment GetById(int id)
        {
            return _context.AdveretisedApartments.First(item => item.Id == id);
        }

        public async Task<AdveretisedApartment> GetByIdAsync(int id)
        {
            return await _context.AdveretisedApartments.FindAsync(id);
        }

  
        public async Task<AdveretisedApartment> UpdateAsync(AdveretisedApartment adveretisedApartment)
        {
            var AdveretisedApartments = _context.AdveretisedApartments.Update(adveretisedApartment);
            await _context.SaveChangesAsync(AdveretisedApartments);
            return adveretisedApartment;
        }
    }
}
