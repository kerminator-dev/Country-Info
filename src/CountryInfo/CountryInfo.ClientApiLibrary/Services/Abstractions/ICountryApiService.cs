using CountryInfo.ClientApiLibrary.Requests;
using CountryInfo.Shared.DTOs.Responses;

namespace CountryInfo.ClientApiLibrary.Services.Abstractions
{
    public interface ICountryApiService : IGetAllApiServiceRequest<CountryResponseDTO>,
                                        IGetByIdApiServiceRequest<CountryWithStatesResponseDTO>,
                                        IGetByPhoneCodeApiServiceRequest<IEnumerable<CountryResponseDTO>>,
                                        IGetCountApiServiceRequest
    {
    }
}
