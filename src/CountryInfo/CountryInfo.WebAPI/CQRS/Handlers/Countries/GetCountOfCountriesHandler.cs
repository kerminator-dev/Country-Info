using CountryInfo.WebAPI.CQRS.Queries.Countries;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Handlers.Countries
{
    public class GetCountOfCountriesHandler : IRequestHandler<GetCountOfCountriesQuery, int>
    {
        private readonly ICountryService _countryService;

        public GetCountOfCountriesHandler(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public async Task<int> Handle(GetCountOfCountriesQuery request, CancellationToken cancellationToken)
        {
            return await _countryService.GetCountAsync();
        }
    }
}
