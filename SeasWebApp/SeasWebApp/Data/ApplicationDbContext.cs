using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SeasWebApp.Models;

namespace SeasWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<UserToClass> UserToClass { get; set; }
        public DbSet<AccountUser> AccountToUsers { get; set; }
        public DbSet<UserAbsent> UserAbsent { get; set; }
        public DbSet<UserGrade> UserGrade { get; set; }
    }
}
