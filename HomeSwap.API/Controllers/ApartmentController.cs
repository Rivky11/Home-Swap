using HomeSwap.Common.DTOs;
using HomeSwap.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeSwap.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        private readonly IApartmentService _apartmentService;
        public ApartmentController(IApartmentService apartmentService)
        {
            _apartmentService = apartmentService;
        }

        [HttpGet]
        public async Task<List<ApartmentDTO>> GetAll()
        {
            return await _apartmentService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ApartmentDTO> GetById(int id)
        {
            return await _apartmentService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<ApartmentDTO>> Post([FromBody] ApartmentPostModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _apartmentService.AddAsync(new ApartmentDTO
            {
                Id = model.Id,
                UserId = model.UserId,
                City = model.City,
                Address = model.Address,
                NumBeds = model.NumBeds,
                NumRooms = model.NumRooms,
                Area = model.Area,
                Floor = model.Floor,
                IsConditioned = model.IsConditioned,
                IsMMD = model.IsMMD,
                IsAccessForDisabled = model.IsAccessForDisabled,
                IsElevators = model.IsElevators,
                IsKosherkitchen = model.IsKosherkitchen,
                IsRenovated = model.IsRenovated,
                IsBars = model.IsBars,
                IsForSleepingOnly = model.IsForSleepingOnly
            });
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<ApartmentDTO>> Put(int id, [FromBody] ApartmentPostModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _apartmentService.UpdateAsync(new ApartmentDTO
            {
                Id = id,
                UserId = model.UserId,
                City = model.City,
                Address = model.Address,
                NumBeds = model.NumBeds,
                NumRooms = model.NumRooms,
                Area = model.Area,
                Floor = model.Floor,
                IsConditioned = model.IsConditioned,
                IsMMD = model.IsMMD,
                IsAccessForDisabled = model.IsAccessForDisabled,
                IsElevators = model.IsElevators,
                IsKosherkitchen = model.IsKosherkitchen,
                IsRenovated = model.IsRenovated,
                IsBars = model.IsBars,
                IsForSleepingOnly = model.IsForSleepingOnly
            });
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _apartmentService.DeleteAsync(id);
            return NoContent();
        }
    }
}
