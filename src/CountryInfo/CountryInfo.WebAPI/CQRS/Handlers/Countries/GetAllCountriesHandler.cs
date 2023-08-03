using AutoMapper;
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
        private readonly IMapper _mapper;

        public GetAllCountriesHandler(ICountryService countryService, IMapper mapper)
        {
            _countryService = countryService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CountryResponseDTO>> Handle(GetAllCountriesQuery request, CancellationToken cancellationToken)
        {
            var countries = await _countryService.GetAllAsync();

            return _mapper.Map<IEnumerable<CountryResponseDTO>>(countries);
        }
    }
}
