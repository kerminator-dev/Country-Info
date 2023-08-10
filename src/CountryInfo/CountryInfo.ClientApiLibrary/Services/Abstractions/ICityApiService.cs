using CountryInfo.ClientApiLibrary.Requests;
using CountryInfo.Shared.DTOs.Responses;

namespace CountryInfo.ClientApiLibrary.Services.Abstractions
{
    public interface ICityApiService : ISearchApiServiceRequest<CityResponseDTO, string>,
                                         IGetByIdApiServiceRequest<CityResponseDTO>,
                                         IGetCountApiServiceRequest
    {
    }
}
