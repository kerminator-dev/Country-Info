using CountryInfo.Shared.DTOs.Responses;
using CountryInfo.WebAPI.CQRS.Queries.Cities;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Handlers.Cities
{
    public class GetCityByIdHandler : IRequestHandler<GetCityByIdQuery, CityResponseDTO>
    {
        private readonly ICityService _cityService;

        public GetCityByIdHandler(ICityService cityService)
        {
            _cityService = cityService;
        }

        public async Task<CityResponseDTO> Handle(GetCityByIdQuery request, CancellationToken cancellationToken)
        {
            var city = await _cityService.GetAsync(request.CityId);

            return new CityResponseDTO()
            {
                Id = city.Id,
                Name = city.Name,
            };
        }
    }
}
