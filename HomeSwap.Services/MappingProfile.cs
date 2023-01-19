using AutoMapper;
using HomeSwap.Common.DTOs;
using HomeSwap.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HomeSwap.Services
{
    public class MappingProfile:Profile
    {
        public MappingProfile() {
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<UserDetailsDTO, UserDetails>().ReverseMap();
            CreateMap<ApartmentDTO, Apartment>().ReverseMap();
            CreateMap<ApartmentRatingDTO, ApartmentRating>().ReverseMap();
            CreateMap<ApartmentPicturesDTO, ApartmentPictures>().ReverseMap();
            CreateMap<AdveretisedApartmentDTO, AdveretisedApartment>().ReverseMap();
        }

     
    }
}
