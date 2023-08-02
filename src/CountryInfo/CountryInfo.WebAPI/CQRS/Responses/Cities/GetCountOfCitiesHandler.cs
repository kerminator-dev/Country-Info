using CountryInfo.WebAPI.CQRS.Queries.Cities;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Responses.Cities
{
    public class GetCountOfCitiesHandler : IRequestHandler<GetCountOfCitiesQuery, int>
    {
        private readonly ICityService _cityService;

        public GetCountOfCitiesHandler(ICityService cityService)
        {
            _cityService = cityService;
        }

        public async Task<int> Handle(GetCountOfCitiesQuery request, CancellationToken cancellationToken)
        {
            return await _cityService.GetCountAsync();
        }
    }
}
