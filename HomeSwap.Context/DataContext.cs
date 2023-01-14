using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Security;
using HomeSwap.Repositories.Interfaces;
using HomeSwap.Repositories.Entities;

namespace HomeeSwap.Context
{
    public class DataContext : DbContext, IContext
    {
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<ApartmentPictures> ApartmentPictures { get; set; }
        public DbSet<ApartmentRating> ApartmentRatings { get; set; }
        public DbSet<AdveretisedApartment> AdveretisedApartments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apartment>().Property(b => b.Id).IsRequired();
            modelBuilder.Entity<AdveretisedApartment>().Property(b => b.Id).IsRequired();
            modelBuilder.Entity<ApartmentPictures>().Property(b => b.Id).IsRequired();
            modelBuilder.Entity<ApartmentRating>().Property(b => b.Id).IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Id).IsRequired();
            modelBuilder.Entity<UserDetails>().Property(b => b.UserId).IsRequired();
        }

    }
}