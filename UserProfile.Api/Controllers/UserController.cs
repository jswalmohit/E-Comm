using Microsoft.AspNetCore.Mvc;
using UserProfile.Common.Modals;
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

namespace UserProfile.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
    {
        // For demonstration — a temporary in-memory store
        private static readonly Dictionary<int, UserModel> _users = new();

        /// <summary>
        /// Create a new user
        /// </summary>
        [HttpPost("create")]
        public async Task<IActionResult> CreateUser([FromBody] UserModel user)
        {
            if (user == null)
                return BadRequest("User data is required.");

            if (_users.ContainsKey(user.Id))
                return Conflict($"User with ID {user.Id} already exists.");

            // Simulate async operation (e.g., database insert)
            await Task.Delay(50);

            _users[user.Id] = user;
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        /// <summary>
        /// Update an existing user
        /// </summary>
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] UserModel updatedUser)
        {
            if (!_users.ContainsKey(id))
                return NotFound($"User with ID {id} not found.");

            if (updatedUser == null)
                return BadRequest("User data is required.");

            await Task.Delay(50); // Simulate async update

            _users[id] = updatedUser;
            return Ok(updatedUser);
        }

        /// <summary>
        /// Optional: Get user by ID (for CreatedAtAction link)
        /// </summary>
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            if (!_users.ContainsKey(id))
                return NotFound();

            return Ok(_users[id]);
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> origin/master
=======
>>>>>>> 1a5c9ac (Dev mohit (#1))
=======
>>>>>>> 1a5c9ac (Dev mohit (#1))
        }
    }
}
