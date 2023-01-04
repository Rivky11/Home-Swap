using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HomeSwap.Services.Interfaces;
namespace HomeSwap.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertisedApartmentController : ControllerBase
    {
        private readonly IAdvertisedApartmentService _advertisedApartmentService;
        public AdvertisedApartmentController(IAdvertisedApartmentService advertisedApartmentService)
        {
            _advertisedApartmentService = advertisedApartmentService;
        }

        [HttpGet]
        public async Task<List<AdvertisedApartmentDTO>> GetAll()
        {
            return await _advertisedApartmentService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<AdvertisedApartmentDTO> GetById(int id)
        {
            return await _advertisedApartmentService.GetAdvertisedApartmentByIdAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<AdvertisedApartmentDTO>> Post([FromBody] AdvertisedApartmentPostModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _advertisedApartmentService.AddAsync(new AdvertisedApartmentDTO
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
        public async Task<ActionResult<AdvertisedApartmentDTO>> Put(int id, [FromBody] AdvertisedApartmentPostModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _advertisedApartmentService.UpdateAsync(new AdvertisedApartmentDTO
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
            await _advertisedApartmentService.DeleteAsync(id);
            return NoContent();
        }
    }
}