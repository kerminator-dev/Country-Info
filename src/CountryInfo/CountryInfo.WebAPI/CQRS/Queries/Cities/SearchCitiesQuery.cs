using CountryInfo.WebAPI.Entities;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Queries.Cities
{
    public class SearchCitiesQuery : IRequest<IEnumerable<City>>
    {
        public string Value { get; set; }

        public SearchCitiesQuery(string value)
        {
            Value = value;
        }
    }
}
