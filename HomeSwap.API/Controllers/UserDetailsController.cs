using HomeSwap.Common.DTOs;
using HomeSwap.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeSwap.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        private readonly IUserDetailsService _userDetailsService;
        public UserDetailsController(IUserDetailsService userDetailsService)
        {
            _userDetailsService = userDetailsService;
        }

        [HttpGet]
        public async Task<List<UserDetailsDTO>> GetAll()
        {
            return await _userDetailsService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<UserDetailsDTO> GetById(int id)
        {
            return await _userDetailsService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<UserDetailsDTO>> Post([FromBody] UserDetailsPostModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _userDetailsService.AddAsync(new UserDetailsDTO
            {
                userId = model.UserId,
                Migzar = model.Migzar,
                Type = model.Type,
                Status = model.Status
            });
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<UserDetailsDTO>> Put(int id, [FromBody] UserDetailsPostModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _userDetailsService.UpdateAsync(new UserDetailsDTO
            {
                userId = id,
                Migzar = model.Migzar,
                Type = model.Type,
                Status = model.Status
            });
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _userDetailsService.DeleteAsync(id);
            return NoContent();
        }
    }
}
