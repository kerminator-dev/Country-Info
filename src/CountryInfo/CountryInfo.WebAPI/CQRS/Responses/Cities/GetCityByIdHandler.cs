using CountryInfo.WebAPI.CQRS.Queries.Cities;
using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Responses.Cities
{
    public class GetCityByIdHandler : IRequestHandler<GetCityByIdQuery, City>
    {
        private readonly ICityService _cityService;

        public GetCityByIdHandler(ICityService cityService)
        {
            _cityService = cityService;
        }

        public async Task<City> Handle(GetCityByIdQuery request, CancellationToken cancellationToken)
        {
            return await _cityService.GetAsync(request.CityId);
        }
    }
}
