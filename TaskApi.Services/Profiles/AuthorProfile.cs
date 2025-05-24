using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TaskApi.Models;
using TaskApi.Services.Models;

namespace TaskApi.Services.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDto>()
                .ForMember(dest => dest.Address,
                opt => opt.MapFrom(src => $"{src.AddressNo}, {src.City}, {src.Region}"));
        }
    }
}
