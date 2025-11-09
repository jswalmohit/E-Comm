using UserProfile.Common.Modals;
using UserProfile.Repository.Interfaces;
using UserProfile.Service.Interfaces;

namespace UserProfile.Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserModel?> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<UserModel> CreateUserAsync(UserModel user)
        {
            return await _userRepository.CreateAsync(user);
        }

        public async Task<UserModel?> UpdateUserAsync(int id, UserModel user)
        {
            user.Id = id;
            return await _userRepository.UpdateAsync(user);
        }
    }
}
