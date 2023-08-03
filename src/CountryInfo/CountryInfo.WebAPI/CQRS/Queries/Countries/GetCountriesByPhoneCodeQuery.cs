using CountryInfo.Shared.DTOs.Responses;
using CountryInfo.WebAPI.Entities;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Queries.Countries
{
    public class GetCountriesByPhoneCodeQuery : IRequest<IEnumerable<CountryResponseDTO>>
    {
        public int PhoneCode { get; set; }

        public GetCountriesByPhoneCodeQuery(int phoneCode)
        {
            PhoneCode = phoneCode;
        }
    }
}
