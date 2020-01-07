using System;
using System.Globalization;
using System.Linq;
using AutoMapper;
using MaHY.API.Data;
using MaHY.API.Dtos;
using MaHY.API.Models;

namespace MaHY.API.Helpers {
    public class AutoMapperProfiles : Profile {
        private readonly DataContext _context;

        public AutoMapperProfiles (DataContext context) {
            _context = context;
        }
        // public AutoMapperProfiles () {
        //     CreateMap<User, UserForListDto> ()
        //         .ForMember (dest => dest.Age, opt => {
        //             opt.MapFrom (d => d.DateOfBirth.CalculateAge ());
        //         });  
        //     CreateMap<Role, RoleListDto> ();     
        // }
    }
}