using Microsoft.EntityFrameworkCore;
using System;
using WellnessApp.Core;

namespace WellnessApp.DAL
{
    public class WellnessAppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public WellnessAppDbContext() : base()
        {
        }
        public WellnessAppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
