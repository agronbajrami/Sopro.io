using AutoMapper;
using Domain.Entities;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<MovieModel, Movie>()
                .ReverseMap()
                .ForMember(dest => dest.Person, opt => opt.MapFrom(src => src.Person))
                .ForMember(dest => dest.GenreClass, opt => opt.MapFrom(src => src.Genre));
                
            CreateMap<GenreModel, GenreClass>().ReverseMap();
            CreateMap<PersonModel, Person>().ReverseMap();
        }
    }
}
