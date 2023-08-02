using CountryInfo.WebAPI.CQRS.Queries.Countries;
using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Responses.Countries
{
    public class GetCountriesByPhoneCodeHandler : IRequestHandler<GetCountriesByPhoneCodeQuery, IEnumerable<Country>>
    {
        private readonly ICountryService _countryService;

        public GetCountriesByPhoneCodeHandler(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public async Task<IEnumerable<Country>> Handle(GetCountriesByPhoneCodeQuery request, CancellationToken cancellationToken)
        {
            return await _countryService.GetByPhoneCodeAsync(request.PhoneCode);
        }
    }
}
