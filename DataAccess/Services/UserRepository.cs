using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Lethal.Developer.Helpers;
using Lethal.Developer.DataAccess.Interfaces;
using Lethal.Developer.Users.Models;
using Lethal.Developer.Data;

namespace bniAPI.DataAccess.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly IServiceProvider _serviceProvider;

        public UserRepository(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task<User> AuthenticateUserAsync(string userName, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                    return null;

                var db = _serviceProvider.GetService<ApplicationDbContext>();
                var user = await db.Users.SingleOrDefaultAsync(x => x.UserName == userName);
                bool authenticated;

                if (user == null)
                    return null;

                authenticated = VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt);

                return authenticated ? user : null;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<User> CreateUserAsync(User user, string password)
        {
            try
            {
                var db = _serviceProvider.GetService<ApplicationDbContext>();

                if (string.IsNullOrWhiteSpace(password))
                    throw new AppException("Password is required");

                if (db.Users.Any(x => x.UserName == user.UserName))
                    throw new AppException($"Username: {user.UserName} is already taken");

                byte[] passwordHash, passwordSalt;
                CreatePasswordHash(password, out passwordHash, out passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;

                db.Users.Add(user);
                await db.SaveChangesAsync();

                return user;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<User> GetUserAsync(Guid userId)
        {
            try
            {
                var db = _serviceProvider.GetService<ApplicationDbContext>();

                return await db.Users.SingleOrDefaultAsync(u => u.UserId == userId);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task UpdateUserAsync(User userParam, string password = null)
        {
            try
            {
                var db = _serviceProvider.GetService<ApplicationDbContext>();
                var user = await db.Users.SingleOrDefaultAsync(u => u.UserId == userParam.UserId);

                // update username if it has changed
                if (!string.IsNullOrWhiteSpace(userParam.UserName) && userParam.UserName != user.UserName)
                {
                    // throw error if the new UserName is already taken
                    if (db.Users.Any(x => x.UserName == userParam.UserName))
                        //throw new AppException("UserName " + userParam.UserName + " is already taken");

                    user.UserName = userParam.UserName;
                }

                // update user properties if provided
                if (!string.IsNullOrWhiteSpace(userParam.FirstName))
                    user.FirstName = userParam.FirstName;

                if (!string.IsNullOrWhiteSpace(userParam.LastName))
                    user.LastName = userParam.LastName;

                // update password if provided
                if (!string.IsNullOrWhiteSpace(password))
                {
                    byte[] passwordHash, passwordSalt;
                    CreatePasswordHash(password, out passwordHash, out passwordSalt);

                    user.PasswordHash = passwordHash;
                    user.PasswordSalt = passwordSalt;
                }

                db.Users.Update(user);
                await db.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteUserAsync(Guid userId)
        {
            try
            {
                var db = _serviceProvider.GetService<ApplicationDbContext>();
                var user = await db.Users.SingleOrDefaultAsync(u => u.UserId == userId);

                if (user != null)
                {
                    db.Users.Remove(user);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
            if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
            if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");

            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }

            return true;
        }
    }
}
