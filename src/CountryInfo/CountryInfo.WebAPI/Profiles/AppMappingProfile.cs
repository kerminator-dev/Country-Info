using AutoMapper;
using CountryInfo.Shared.DTOs.Responses;
using CountryInfo.WebAPI.Entities;

namespace CountryInfo.WebAPI.Profiles
{
    public sealed class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            _ = CreateMap<Country, CountryResponseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ShortName, opt => opt.MapFrom(src => src.ShortName))
                .ForMember(dest => dest.PhoneCode, opt => opt.MapFrom(src => src.PhoneCode));

            _ = CreateMap<Country, CountryWithStatesResponseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ShortName, opt => opt.MapFrom(src => src.ShortName))
                .ForMember(dest => dest.PhoneCode, opt => opt.MapFrom(src => src.PhoneCode));
                //.ForMember(dest => dest.States, opt => opt.SetMappingOrder());


            _ = CreateMap<State, StateResponseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CountryId));

            _ = CreateMap<State, StateWithCitiesResponseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CountryId));
                //.ForMember(dest => dest.Cities, opt => opt.MapAtRuntime());


            _ = CreateMap<City, CityResponseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.StateId, opt => opt.MapFrom(src => src.StateId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        }
    }
}
