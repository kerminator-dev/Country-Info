using CountryInfo.Shared.DTOs.Responses;
using CountryInfo.WebAPI.CQRS.Queries.Countries;
using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Handlers.Countries
{
    public class GetCountriesByPhoneCodeHandler : IRequestHandler<GetCountriesByPhoneCodeQuery, IEnumerable<CountryResponseDTO>>
    {
        private readonly ICountryService _countryService;

        public GetCountriesByPhoneCodeHandler(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public async Task<IEnumerable<CountryResponseDTO>> Handle(GetCountriesByPhoneCodeQuery request, CancellationToken cancellationToken)
        {
            var result = await _countryService.GetByPhoneCodeAsync(request.PhoneCode);

            return result.Select(x => new CountryResponseDTO()
            {
                Id = x.Id,
                Name = x.Name,
                PhoneCode = x.PhoneCode,
                ShortName = x.ShortName,
            });
        }
    }
}
