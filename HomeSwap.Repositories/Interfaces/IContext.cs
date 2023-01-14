using HomeSwap.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeSwap.Repositories.Interfaces
{
    public interface IContext
    {
        DbSet<Apartment> Apartments { get; set; }

        DbSet<ApartmentPictures> ApartmentPictures { get; set; }

        DbSet<ApartmentRating> ApartmentRatings { get; set; }

        DbSet<AdveretisedApartment> AdveretisedApartments { get; set; }
        
        DbSet<User> Users { get; set; }

        DbSet<UserDetails> UserDetails { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
