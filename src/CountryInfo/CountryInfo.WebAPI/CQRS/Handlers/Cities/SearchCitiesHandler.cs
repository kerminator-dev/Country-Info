using CountryInfo.Shared.DTOs.Responses;
using CountryInfo.WebAPI.CQRS.Queries.Cities;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Handlers.Cities
{
    public class SearchCitiesHandler : IRequestHandler<SearchCitiesQuery, IEnumerable<CityResponseDTO>>
    {
        private readonly ICityService _cityService;

        public SearchCitiesHandler(ICityService cityService)
        {
            _cityService = cityService;
        }

        public async Task<IEnumerable<CityResponseDTO>> Handle(SearchCitiesQuery request, CancellationToken cancellationToken)
        {
            var cities = await _cityService.Search(request.Value);

            return cities.Select(city => new CityResponseDTO()
            {
                Id = city.Id,
                Name = city.Name,
            });
        }
    }
}
