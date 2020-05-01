using Lethal.Developer.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.DataAccess.Interfaces
{
    public interface IUserRepository
    {
        Task<User> AuthenticateUserAsync(string userName, string password);
        Task<User> CreateUserAsync(User user, string password);
        Task<User> GetUserAsync(Guid userId);
        Task UpdateUserAsync(User user, string password = null);
        Task DeleteUserAsync(Guid userId);
    }
}
