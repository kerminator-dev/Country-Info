using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Specifications.Abstractions;
using System.Linq.Expressions;

namespace CountryInfo.WebAPI.Specifications.Implementation
{
    public class CountryByPhoneCodeSpecification : ISpecification<Country>
    {
        private readonly int _phoneCode;

        public CountryByPhoneCodeSpecification(int phoneCode)
        {
            _phoneCode = phoneCode;
        }

        public bool IsSatisfiedBy(Country entity)
        {
            return entity.PhoneCode == _phoneCode;
        }

        public Expression<Func<Country, bool>> ToExpression()
        {
            return c => c.PhoneCode == _phoneCode;
        }
    }
}
