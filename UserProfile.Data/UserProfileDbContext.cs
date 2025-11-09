using Microsoft.EntityFrameworkCore;
using UserProfile.Common.Modals;

namespace UserProfile.Data
{
    public class UserProfileDbContext(DbContextOptions<UserProfileDbContext> options) : DbContext(options)
    {
        public DbSet<UserModel> Users { get; set; }

    }
}
