using CountryInfo.WebAPI.CQRS.Queries.Countries;
using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Responses.Countries
{
    public class GetCountryByIdHandler : IRequestHandler<GetCountryByIdQuery, Country>
    {
        private readonly ICountryService _countryService;

        public GetCountryByIdHandler(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public async Task<Country> Handle(GetCountryByIdQuery request, CancellationToken cancellationToken)
        {
            return await _countryService.GetAsync(request.CountryId);
        }
    }
}
