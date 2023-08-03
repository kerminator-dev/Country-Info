using CountryInfo.Shared.DTOs.Responses;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Queries.Cities
{
    public class GetCityByIdQuery : IRequest<CityResponseDTO>
    {
        public int CityId { get; set; }

        public GetCityByIdQuery(int cityId)
        {
            CityId = cityId;
        }
    }
}
