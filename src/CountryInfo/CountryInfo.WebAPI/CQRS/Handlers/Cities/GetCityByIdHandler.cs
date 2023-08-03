using AutoMapper;
using CountryInfo.Shared.DTOs.Responses;
using CountryInfo.WebAPI.CQRS.Queries.Cities;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Handlers.Cities
{
    public class GetCityByIdHandler : IRequestHandler<GetCityByIdQuery, CityResponseDTO>
    {
        private readonly ICityService _cityService;
        private readonly IMapper _mapper;

        public GetCityByIdHandler(ICityService cityService, IMapper mapper)
        {
            _cityService = cityService;
            _mapper = mapper;
        }

        public async Task<CityResponseDTO> Handle(GetCityByIdQuery request, CancellationToken cancellationToken)
        {
            var city = await _cityService.GetAsync(request.CityId);

            return _mapper.Map<CityResponseDTO>(city);
        }
    }
}
