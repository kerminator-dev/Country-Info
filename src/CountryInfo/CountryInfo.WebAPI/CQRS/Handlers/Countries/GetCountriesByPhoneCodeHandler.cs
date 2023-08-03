using AutoMapper;
using CountryInfo.Shared.DTOs.Responses;
using CountryInfo.WebAPI.CQRS.Queries.Countries;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Handlers.Countries
{
    public class GetCountriesByPhoneCodeHandler : IRequestHandler<GetCountriesByPhoneCodeQuery, IEnumerable<CountryResponseDTO>>
    {
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;

        public GetCountriesByPhoneCodeHandler(ICountryService countryService, IMapper mapper)
        {
            _countryService = countryService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CountryResponseDTO>> Handle(GetCountriesByPhoneCodeQuery request, CancellationToken cancellationToken)
        {
            var countries = await _countryService.GetByPhoneCodeAsync(request.PhoneCode);

            return _mapper.Map<IEnumerable<CountryResponseDTO>>(countries);
        }
    }
}
