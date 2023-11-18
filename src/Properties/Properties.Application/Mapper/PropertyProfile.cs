using BuildingMarket.Properties.Application.Models;
using BuildingMarket.Properties.Domain.Entities;
using AutoMapper;
using BuildingMarket.Properties.Application.Features.Properties.Commands.AddProperty;

namespace BuildingMarket.Properties.Application.Mapper
{
    public class PropertyProfile : Profile
    {
        public PropertyProfile()
        {
            CreateMap<Property, PropertyModel>()
                .ReverseMap();

            CreateMap<Property, AddPropertyCommand>()
               .ForMember(x => x.Model, opt => opt.MapFrom(src => src))
               .ReverseMap();
        }
    }
}