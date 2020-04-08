using System;
using System.Collections.Generic;
using System.Text;
using Lethal.Developer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lethal.Developer.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Topic>(topic =>
            {
                //TODO: need to determine the right way for setting up these relationships

                //topic
                //    .Property(n => n.UserId).IsRequired();

                topic.HasData(
                    new Topic { Id = 1, Name = "Data Structures" }
                    );
            });
        }

    }
}
