using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using WellnessApp.Core;

namespace WellnessApp.DAL
{
    //public class WellnessAppDbContext : DbContext
    //public class WellnessAppDbContext : IdentityDbContext<AppUser>
    public class WellnessAppDbContext : IdentityDbContext
    {
        //new public DbSet<User> Users { get; set; }
        //public DbSet<Address> Addresses { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }

        public WellnessAppDbContext() : base()
        {
        }
        public WellnessAppDbContext(DbContextOptions<WellnessAppDbContext> options) : base(options)
        {
        }

    }

}
