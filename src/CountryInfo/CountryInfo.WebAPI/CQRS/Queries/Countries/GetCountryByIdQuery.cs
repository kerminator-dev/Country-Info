using CountryInfo.Shared.DTOs.Responses;
using CountryInfo.WebAPI.Entities;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Queries.Countries
{
    public class GetCountryByIdQuery : IRequest<CountryWithStatesResponseDTO>
    {
        public int CountryId { get; set; }

        public GetCountryByIdQuery(int countryId)
        {
            CountryId = countryId;
        }
    }
}
