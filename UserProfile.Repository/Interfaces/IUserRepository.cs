using UserProfile.Common.Modals;

namespace UserProfile.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<UserModel?> GetByIdAsync(int id);
        Task<UserModel> CreateAsync(UserModel user);
        Task<UserModel?> UpdateAsync(UserModel user);
    }
}
