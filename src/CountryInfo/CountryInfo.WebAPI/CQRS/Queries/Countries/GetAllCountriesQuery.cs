using CountryInfo.Shared.DTOs.Responses;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Queries.Countries
{
    public class GetAllCountriesQuery : IRequest<IEnumerable<CountryResponseDTO>>
    {

    }
}
