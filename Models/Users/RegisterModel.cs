using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lethal.Developer.Users.Models
{
    [NotMapped]
    public class RegisterModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        //TODO: Write logic to ensure only unique username gets added to db;
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public string Email { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Ethnicity { get; set; }
    }
}