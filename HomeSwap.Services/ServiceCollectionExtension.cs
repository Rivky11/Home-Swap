using AutoMapper;
using HomeSwap.Repositories;
using HomeSwap.Services.Interfaces;
using HomeSwap.Services.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Services
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserDetailsService, UserDetailsService>();
            services.AddScoped<IAdveretisedApartmentService, AdvertisedApartmentService>();
            services.AddScoped<IApartmentService, ApartmentService>();
            services.AddScoped<IApartmentRatingService, ApartmentRatingService>();
            services.AddScoped<IApartmentPicturesService, ApartmentPicturesService>();

            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
