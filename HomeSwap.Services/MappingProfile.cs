using HomeSwap.Common.DTOs;
using HomeSwap.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;


namespace HomeSwap.Services
{
    public class MappingProfile
    {
        public MappingProfile() {
            CreateMap<UserDTO, User>().ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Title)).ReverseMap();
            CreateMap<UserDetailsDTO, UserDetails>().ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Title)).ReverseMap();
            CreateMap<ApartmentDTO, Apartment>().ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Title)).ReverseMap();
            CreateMap<ApartmentRatingDTO, ApartmentRating>().ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Title)).ReverseMap();
            CreateMap<ApartmentPicturesDTO, ApartmentPictures>().ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Title)).ReverseMap();
            CreateMap<AdveretisedApartmentDTO, AdveretisedApartment>().ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Title)).ReverseMap();
        }
    }
}
