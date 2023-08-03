using AutoMapper;
using CountryInfo.Shared.DTOs.Responses;
using CountryInfo.WebAPI.CQRS.Queries.Cities;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Handlers.Cities
{
    public class SearchCitiesHandler : IRequestHandler<SearchCitiesQuery, IEnumerable<CityResponseDTO>>
    {
        private readonly ICityService _cityService;
        private readonly IMapper _mapper;

        public SearchCitiesHandler(ICityService cityService, IMapper mapper)
        {
            _cityService = cityService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CityResponseDTO>> Handle(SearchCitiesQuery request, CancellationToken cancellationToken)
        {
            var cities = await _cityService.Search(request.Value);

            return _mapper.Map<IEnumerable<CityResponseDTO>>(cities);
        }
    }
}
