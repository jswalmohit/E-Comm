using Authentication.Services.Implementation;
using Authentication.Services.Interfaces;
using Token.Services.Interfaces;

namespace Token.Api.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserAuthService, UserAuthService>();
        }
    }
}
