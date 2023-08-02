using CountryInfo.WebAPI.Entities;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Queries.Cities
{
    public class GetCityByIdQuery : IRequest<City>
    {
        public int CityId { get; set; }

        public GetCityByIdQuery(int cityId)
        {
            CityId = cityId;
        }
    }
}
