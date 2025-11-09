using UserProfile.Data;
using UserProfile.Repository.Implementation;
using UserProfile.Repository.Interfaces;
using UserProfile.Service.Implementation;
using UserProfile.Service.Interfaces;

namespace UserProfile.Api.Extensions
{
    public static class IServiceCollectionExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<UserDbContext>();
        }
    }
}
