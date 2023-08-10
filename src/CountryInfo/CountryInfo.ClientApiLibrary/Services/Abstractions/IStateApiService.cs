using CountryInfo.ClientApiLibrary.Requests;
using CountryInfo.Shared.DTOs.Responses;

namespace CountryInfo.ClientApiLibrary.Services.Abstractions
{
    public interface IStateApiService : IGetByIdApiServiceRequest<StateWithCitiesResponseDTO>,
                                        IGetCountApiServiceRequest
    {

    }
}
