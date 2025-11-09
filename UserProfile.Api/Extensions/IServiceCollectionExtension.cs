using Microsoft.Extensions.DependencyInjection;
using UserProfile.Data;
using UserProfile.Repository.Implementation;
using UserProfile.Repository.Interfaces;

namespace UserProfile.Api.Extensions
{
    public static class IServiceCollectionExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<UserDbContext>();
        }
    }
}
