
using Authentication.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Token.Common.Modals;
using Token.Services;
using Token.Services.Interfaces;

namespace Token.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IUserAuthService userAuthService) : ControllerBase
    {
        private readonly IUserAuthService _userAuthService = userAuthService;

        [HttpPost]
        public async Task<IActionResult> GenerateJWTToken([FromBody] LoginModel login)
        {

           string token = await _userAuthService.GetUserToken(login.LoginId, login.Password);

            return Ok(token);
        }
    }
}
