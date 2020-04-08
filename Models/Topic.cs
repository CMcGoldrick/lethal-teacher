using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public Guid UserId { get; set; }

        public virtual IdentityUser User { get; set; }
    }
}
