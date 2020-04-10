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
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Theory> Theory { get; set; }
        public DbSet<Result> Results { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(n => n.UserId).IsRequired();

                entity.HasData(
                        new Topic { Id = 1, Name = "Data Structures", UserId = Guid.Parse("9776506B-8CFE-448F-1BF5-08D7DCE61A3B"), CreatedDate = DateTime.Now  }
                    );
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
                
                entity.Property(n => n.UserId).IsRequired();
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(n => n.UserId).IsRequired();

            });

            modelBuilder.Entity<Theory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(n => n.UserId).IsRequired();
            });
        }
    }
}
