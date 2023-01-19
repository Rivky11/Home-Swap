using HomeSwap.Common.DTOs;
using HomeSwap.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeSwap.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentPicturesController : ControllerBase
    {
        private readonly IApartmentPicturesService _apartmentPicturesService;
        public ApartmentPicturesController(IApartmentPicturesService apartmentPicturesService)
        {
            _apartmentPicturesService = apartmentPicturesService;
        }

        [HttpGet]
        public async Task<List<ApartmentPicturesDTO>> GetAll()
        {
            return await _apartmentPicturesService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ApartmentPicturesDTO> GetById(int id)
        {
            return await _apartmentPicturesService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<ApartmentPicturesDTO>> Post([FromBody] ApartmentPicturesPostModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _apartmentPicturesService.AddAsync(new ApartmentPicturesDTO
            {
                Id = model.Id,
                ApartmentId = model.ApartmentId,
                Picture = model.Picture
            });
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<ApartmentPicturesDTO>> Put(int id, [FromBody] ApartmentPicturesPostModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _apartmentPicturesService.UpdateAsync(new ApartmentPicturesDTO
            {
                Id = id,
                ApartmentId = model.ApartmentId,
                Picture = model.Picture
            });
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _apartmentPicturesService.DeleteAsync(id);
            return NoContent();
        }
    }
}
