using CountryInfo.WebAPI.CQRS.Queries.Cities;
using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Responses.Cities
{
    public class SearchCitiesHandler : IRequestHandler<SearchCitiesQuery, IEnumerable<City>>
    {
        private readonly ICityService _cityService;

        public SearchCitiesHandler(ICityService cityService)
        {
            _cityService = cityService;
        }

        public async Task<IEnumerable<City>> Handle(SearchCitiesQuery request, CancellationToken cancellationToken)
        {
            return await _cityService.Search(request.Value);
        }
    }
}
