using HomeSwap.Repositories.Entities;
using HomeSwap.Repositories.Interfaces;
using HomeSwap.Repositories.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Repositories
{

    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserDetailsRepository, UserDetailsRepository>();
            services.AddScoped<IApartmentRepository, ApartmentRepository>();
            services.AddScoped<IApartmentRatingRepository, ApartmentRatingRepository>();
            services.AddScoped<IApartmentPicturesRepository, ApartmentPicturesRepository>();
            services.AddScoped<IAdveretisedApartmentRepository, AdveretisedApartmentRepository>();
            return services;
        }
    }

}
