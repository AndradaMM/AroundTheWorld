using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace AroundTheWorld.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var passwordHasher = new PasswordHasher<IdentityUser>();
            var defaultUser = new IdentityUser { 
                Id = "5142926a-df50-4ec6-a498-624e6b7834ad",
                UserName = "user@test.com",
                NormalizedUserName = "USER@TEST.COM",
                Email = "user@test.com",
                NormalizedEmail = "USER@TEST.COM",
                EmailConfirmed = true,
                LockoutEnabled = true
            };

            defaultUser.PasswordHash = passwordHasher.HashPassword(defaultUser, "password");

            builder.Entity<IdentityUser>().HasData(defaultUser);
        }
    }
}
