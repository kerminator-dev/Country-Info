using CountryInfo.WebAPI.Entities;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Queries.Countries
{
    public class GetCountryByIdQuery : IRequest<Country>
    {
        public int CountryId { get; set; }

        public GetCountryByIdQuery(int countryId)
        {
            CountryId = countryId;
        }
    }
}
