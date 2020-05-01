using Lethal.Developer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lethal.Developer.Users.Models
{
    public class User
    {
        public User()
        {
            //UserFavoriteTeams = new HashSet<UserFavoriteTeam>();
        }


        public Guid UserId { get; set; }
        public int RoleId { get; set; }
        
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Ethnicity { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public ICollection<Question> Questions { get; set; }
        public ICollection<Topic> Topics { get; set; }
        public ICollection<Result> Results { get; set; }
        public ICollection<Theory> Theory { get; set; }
    }
}