using AutoMapper;
using CountryInfo.Shared.DTOs.Responses;
using CountryInfo.WebAPI.CQRS.Queries.Countries;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Handlers.Countries
{
    public class GetCountryByIdHandler : IRequestHandler<GetCountryByIdQuery, CountryWithStatesResponseDTO>
    {
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;

        public GetCountryByIdHandler(ICountryService countryService, IMapper mapper)
        {
            _countryService = countryService;
            _mapper = mapper;
        }

        public async Task<CountryWithStatesResponseDTO> Handle(GetCountryByIdQuery request, CancellationToken cancellationToken)
        {
            
            var country = await _countryService.GetAsync(request.CountryId);

            return _mapper.Map<CountryWithStatesResponseDTO>(country);
        }
    }
}
