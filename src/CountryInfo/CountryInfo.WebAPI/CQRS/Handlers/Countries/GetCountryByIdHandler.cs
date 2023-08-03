using CountryInfo.Shared.DTOs.Responses;
using CountryInfo.WebAPI.CQRS.Queries.Countries;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Handlers.Countries
{
    public class GetCountryByIdHandler : IRequestHandler<GetCountryByIdQuery, CountryWithStatesResponseDTO>
    {
        private readonly ICountryService _countryService;

        public GetCountryByIdHandler(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public async Task<CountryWithStatesResponseDTO> Handle(GetCountryByIdQuery request, CancellationToken cancellationToken)
        {
            
            var country = await _countryService.GetAsync(request.CountryId);

            // Маппинг
            var response = new CountryWithStatesResponseDTO()
            {
                Id = country.Id,
                Name = country.Name,
                PhoneCode = country.PhoneCode,
                ShortName = country.ShortName,
                States = country.States.Select(s => new StateResponseDTO()
                {
                    Id = s.Id,
                    Name = s.Name,
                }).ToList()
            };

            return response;
        }
    }
}
