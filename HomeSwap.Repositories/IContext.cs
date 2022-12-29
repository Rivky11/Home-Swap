using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeSwap.Repositories.Entities;

namespace HomeSwap.Repositories
{
    public interface IContext
    {
        ISet<AdveretisedApartment> AdveretisedApartments { get; set; }
        ISet<Apartment> Apartments { get; set; }
        ISet<ApartmentPictures> ApartmentsPictures { get; set; }
        ISet<ApartmentRating> ApartmentsRating { get; set; }
        ISet<User> Users { get; set; }
        ISet<UserDetails> UsersDetails { get; set; }

        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
