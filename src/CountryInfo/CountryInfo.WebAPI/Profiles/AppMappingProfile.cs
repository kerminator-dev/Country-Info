using AutoMapper;
using CountryInfo.Shared.DTOs.Responses;
using CountryInfo.WebAPI.Entities;

namespace CountryInfo.WebAPI.Profiles
{
    public sealed class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            _ = CreateMap<City, CityResponseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

            _ = CreateMap<State, StateResponseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

            _ = CreateMap<State, StateWithCitiesResponseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Cities, opt => opt.MapFrom(src => src.Cities));

            _ = CreateMap<Country, CountryResponseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ShortName, opt => opt.MapFrom(src => src.ShortName))
                .ForMember(dest => dest.PhoneCode, opt => opt.MapFrom(src => src.PhoneCode));

            _ = CreateMap<Country, CountryWithStatesResponseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ShortName, opt => opt.MapFrom(src => src.ShortName))
                .ForMember(dest => dest.PhoneCode, opt => opt.MapFrom(src => src.PhoneCode))
                .ForMember(dest => dest.States, opt => opt.MapFrom(src => src.States));
        }
    }
}
