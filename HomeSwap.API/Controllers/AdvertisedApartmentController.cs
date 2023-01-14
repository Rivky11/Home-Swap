using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HomeSwap.Services.Interfaces;
using HomeSwap.Common.DTOs;
using HomeSwap.Services.Services;

namespace HomeSwap.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdveretisedApartmentController : ControllerBase
    {
        private readonly IAdveretisedApartmentService _adveretisedApartmentService;
        public AdveretisedApartmentController(IAdveretisedApartmentService adveretisedApartmentService)
        {
            _adveretisedApartmentService = adveretisedApartmentService;
        }

        [HttpGet]
        public async Task<List<AdveretisedApartmentDTO>> GetAll()
        {
            return await _adveretisedApartmentService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<AdveretisedApartmentDTO> GetById(int id)
        {
            return await _adveretisedApartmentService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<AdveretisedApartmentDTO>> Post([FromBody] AdveretisedApartmentPostModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _adveretisedApartmentService.AddAsync(new AdveretisedApartmentDTO
            {
                Id = model.id,
                ApartmentId = model.ApartmentId,
                DateAdd = model.DateAdd,
                FromDate = model.FromDate,
                ToDate = model.ToDate,
                Status = model.Status
            });
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<AdveretisedApartmentDTO>> Put(int id, [FromBody] AdveretisedApartmentPostModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _adveretisedApartmentService.UpdateAsync(new AdveretisedApartmentDTO
            {
                Id = id,
                ApartmentId = model.ApartmentId,
                DateAdd = model.DateAdd,
                FromDate = model.FromDate,
                ToDate = model.ToDate,
                Status = model.Status
            });
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _adveretisedApartmentService.DeleteAsync(id);
            return NoContent();
        }
    }
}