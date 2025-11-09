using UserProfile.Common.Modals;
using UserProfile.Data;
using UserProfile.Repository.Interfaces;

namespace UserProfile.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;

        public UserRepository(UserDbContext context)
        {
            _context = context;
        }

        public async Task<UserModel?> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<UserModel> CreateAsync(UserModel user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<UserModel?> UpdateAsync(UserModel user)
        {
            var existingUser = await _context.Users.FindAsync(user.Id);
            if (existingUser == null)
                return null;

            existingUser.Username = user.Username;
            existingUser.Email = user.Email;
            existingUser.FullName = user.FullName;

            await _context.SaveChangesAsync();
            return existingUser;
        }
    }
}

