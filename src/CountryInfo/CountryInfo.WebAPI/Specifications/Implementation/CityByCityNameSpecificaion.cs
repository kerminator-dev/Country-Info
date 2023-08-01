using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Specifications.Abstractions;
using System.Linq.Expressions;

namespace CountryInfo.WebAPI.Specifications.Implementation
{
    public class CityByCityNameSpecificaion : ISpecification<City>
    {
        private readonly string _cityName;

        public CityByCityNameSpecificaion(string cityName)
        {
            _cityName = cityName;
        }

        public bool IsSatisfiedBy(City entity)
        {
            return entity.Name.Contains(_cityName);
        }

        public Expression<Func<City, bool>> ToExpression()
        {
            return c => c.Name.Contains(_cityName);
        }
    }
}
