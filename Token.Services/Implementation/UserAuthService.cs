using Authentication.Services.Interfaces;
using Token.Services.Interfaces;

namespace Authentication.Services.Implementation
{
    public class UserAuthService(ITokenService tokenService) : IUserAuthService
    {
        private readonly ITokenService _tokenService = tokenService;

        public async Task<string> GetUserToken(string username, string password)
        {
            if (!await ValidateUserAsync(username, password))
            {
                // Invalid user
                throw new UnauthorizedAccessException("Invalid username or password.");
            }
            var token = await _tokenService.CreateJwtToken(username);
            return token;
        }

        private static Task<bool> ValidateUserAsync(string username, string password)
        {
            var isValid = username == "admin" && password == "Password@123";

            return Task.FromResult(isValid);
        }
    }
}
