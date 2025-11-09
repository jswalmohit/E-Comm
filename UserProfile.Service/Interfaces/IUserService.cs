using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProfile.Common.Modals;

namespace UserProfile.Service.Interfaces
{
    public interface IUserService
    {
        Task<UserModel?> GetUserByIdAsync(int id);
        Task<UserModel> CreateUserAsync(UserModel user);
        Task<UserModel?> UpdateUserAsync(int id, UserModel user);
    }
}
