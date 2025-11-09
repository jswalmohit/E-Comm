
using Microsoft.AspNetCore.Mvc;
using Token.Common.Modals;
using Token.Services;
using Token.Services.Interfaces;

namespace Token.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController(ITokenService tokenService) : ControllerBase
    {
        private readonly ITokenService _tokenService = tokenService;

        [HttpPost]
        public async Task<IActionResult> GenerateJWTToken([FromBody] LoginModel login)
        {
           string token = await _tokenService.CreateJwtToken(login.Username);

            return Ok(new
            {
               token
            });
        }
    }
}
