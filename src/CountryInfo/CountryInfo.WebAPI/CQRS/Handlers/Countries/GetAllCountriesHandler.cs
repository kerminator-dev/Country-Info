using CountryInfo.Shared.DTOs.Responses;
using CountryInfo.WebAPI.CQRS.Queries.Countries;
using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Handlers.Countries
{
    public class GetAllCountriesHandler : IRequestHandler<GetAllCountriesQuery, IEnumerable<CountryResponseDTO>>
    {
        private readonly ICountryService _countryService;

        public GetAllCountriesHandler(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public async Task<IEnumerable<CountryResponseDTO>> Handle(GetAllCountriesQuery request, CancellationToken cancellationToken)
        {
            var result = await _countryService.GetAllAsync();

            return result.Select(c => new CountryResponseDTO()
            {
                Id = c.Id,
                Name = c.Name,
                ShortName = c.ShortName,
                PhoneCode = c.PhoneCode,
            });
        }
    }
}
