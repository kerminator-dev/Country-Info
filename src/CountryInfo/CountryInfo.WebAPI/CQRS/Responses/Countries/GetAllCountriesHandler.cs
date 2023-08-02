using CountryInfo.WebAPI.CQRS.Queries.Countries;
using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Responses.Countries
{
    public class GetAllCountriesHandler : IRequestHandler<GetAllCountriesQuery, IEnumerable<Country>>
    {
        private readonly ICountryService _countryService;

        public GetAllCountriesHandler(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public async Task<IEnumerable<Country>> Handle(GetAllCountriesQuery request, CancellationToken cancellationToken)
        {
            return await _countryService.GetAllAsync();
        }
    }
}
