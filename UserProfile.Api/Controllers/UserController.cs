using Microsoft.AspNetCore.Mvc;
using UserProfile.Common.Modals;
using UserProfile.Service.Interfaces;

namespace UserProfile.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;

        [HttpPost("create")]
        public async Task<IActionResult> CreateUser([FromBody] UserModel user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdUser = await _userService.CreateUserAsync(user);
            return CreatedAtAction(nameof(GetUserById), new { id = createdUser.Id }, createdUser);
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] UserModel user)
        {
            var updatedUser = await _userService.UpdateUserAsync(id, user);
            if (updatedUser == null)
                return NotFound($"User with ID {id} not found.");

            return Ok(updatedUser);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
                return NotFound();

            return Ok(user);
        }
    }
}
