using Microsoft.AspNetCore.Mvc;
using UserProfile.Common.Modals;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using UserProfile.Service.Interfaces;
=======
>>>>>>> origin/master
=======
>>>>>>> 1a5c9ac (Dev mohit (#1))
=======
>>>>>>> 1a5c9ac (Dev mohit (#1))
=======
using UserProfile.Service.Interfaces;
>>>>>>> 2b27439 (adding migrations)

namespace UserProfile.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
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
=======
=======
>>>>>>> 1a5c9ac (Dev mohit (#1))
=======
>>>>>>> 1a5c9ac (Dev mohit (#1))
    public class UserController : ControllerBase
=======
    public class UserController(IUserService userService) : ControllerBase
>>>>>>> 2b27439 (adding migrations)
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

<<<<<<< HEAD
            return Ok(_users[id]);
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> origin/master
=======
>>>>>>> 1a5c9ac (Dev mohit (#1))
=======
>>>>>>> 1a5c9ac (Dev mohit (#1))
=======
            return Ok(user);
>>>>>>> 2b27439 (adding migrations)
        }
    }
}
