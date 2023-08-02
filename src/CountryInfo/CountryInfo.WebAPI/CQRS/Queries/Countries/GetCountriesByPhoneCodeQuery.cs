using CountryInfo.WebAPI.Entities;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Queries.Countries
{
    public class GetCountriesByPhoneCodeQuery : IRequest<IEnumerable<Country>>
    {
        public int PhoneCode { get; set; }

        public GetCountriesByPhoneCodeQuery(int phoneCode)
        {
            PhoneCode = phoneCode;
        }
    }
}
