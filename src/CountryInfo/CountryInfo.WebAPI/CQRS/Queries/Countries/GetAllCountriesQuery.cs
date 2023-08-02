using CountryInfo.WebAPI.Entities;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Queries.Countries
{
    public class GetAllCountriesQuery : IRequest<IEnumerable<Country>>
    {

    }
}
