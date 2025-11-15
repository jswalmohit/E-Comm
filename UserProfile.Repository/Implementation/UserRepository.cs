using UserProfile.Common.Modals;
using UserProfile.Data;
using UserProfile.Repository.Interfaces;

namespace UserProfile.Repository.Implementation
{
    public class UserRepository(UserDbContext context) : IUserRepository
    {
        private readonly UserDbContext _context = context;

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

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            existingUser.LoginId = user.LoginId;
=======
            existingUser.Username = user.Username;
>>>>>>> origin/master
=======
            existingUser.Username = user.Username;
>>>>>>> 1a5c9ac (Dev mohit (#1))
=======
            existingUser.Username = user.Username;
>>>>>>> 1a5c9ac (Dev mohit (#1))
=======
            existingUser.LoginId = user.LoginId;
>>>>>>> 14e31e8 (v2.1)
            existingUser.Email = user.Email;
            existingUser.FullName = user.FullName;

            await _context.SaveChangesAsync();
            return existingUser;
        }
    }
}

