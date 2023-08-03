using CountryInfo.Shared.DTOs.Responses;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Queries.Cities
{
    public class SearchCitiesQuery : IRequest<IEnumerable<CityResponseDTO>>
    {
        public string Value { get; set; }

        public SearchCitiesQuery(string value)
        {
            Value = value;
        }
    }
}
