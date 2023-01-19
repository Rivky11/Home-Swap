using HomeSwap.Common.DTOs;
using HomeSwap.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeSwap.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentRatingController : ControllerBase
    {
        private readonly IApartmentRatingService _apartmentRatingService;
        public ApartmentRatingController(IApartmentRatingService apartmentRatingService)
        {
            _apartmentRatingService = apartmentRatingService;
        }

        [HttpGet]
        public async Task<List<ApartmentRatingDTO>> GetAll()
        {
            return await _apartmentRatingService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ApartmentRatingDTO> GetById(int id)
        {
            return await _apartmentRatingService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<ApartmentRatingDTO>> Post([FromBody] ApartmentRatingPostModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _apartmentRatingService.AddAsync(new ApartmentRatingDTO
            {
                Id = model.Id,
                GuessId = model.GuessID,
                ApartmentId = model.ApartmentId,
                Clean = model.Clean,
                Discreption = model.Discreption
            });
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<ApartmentRatingDTO>> Put(int id, [FromBody] ApartmentRatingPostModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _apartmentRatingService.UpdateAsync(new ApartmentRatingDTO
            {
                Id = id,
                GuessId = model.GuessID,
                ApartmentId = model.ApartmentId,
                Clean = model.Clean,
                Discreption = model.Discreption
            });
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _apartmentRatingService.DeleteAsync(id);
            return NoContent();
        }
    }
}
