using HomeSwap.Common.DTOs;
using HomeSwap.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeSwap.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<List<UserDTO>> GetAll()
        {
            return await _userService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<UserDTO> GetById(int id)
        {
            return await _userService.GetUserByIdAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<UserDTO>> Post([FromBody] UserPostModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _userService.AddAsync(new UserDTO
            {
                Id = model.Id,
                Password = model.Password,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Phone = model.Phone,
                Mail = model.Mail,
                Role = model.Role
            });
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<UserDTO>> Put(int id, [FromBody] UserPostModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _userService.UpdateAsync(new UserDTO
            {
                Id = id,
                Password = model.Password,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Phone = model.Phone,
                Mail = model.Mail,
                Role = model.Role
            });
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _userService.DeleteAsync(id);
            return NoContent();
        }
    }
}
