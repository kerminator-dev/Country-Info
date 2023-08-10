using CountryInfo.ClientApiLibrary.Exceptions;
using CountryInfo.ClientApiLibrary.Services.Abstractions;
using CountryInfo.Shared.DTOs.Responses;

namespace CountryInfo.ClientApiLibrary.Services.Implementation
{
    internal class StateApiService : BaseApiService, IStateApiService
    {
        private const string CONTROLLER_NAME = "States";
        private readonly string _baseServerAddress;

        public StateApiService(string baseServerAddress)
        {
            _baseServerAddress = baseServerAddress;
        }


        public async Task<StateWithCitiesResponseDTO> GetByIdAsync(int id)
        {
            try
            {
                var address = new Uri($"{_baseServerAddress}api/{CONTROLLER_NAME}/{id}");

                return await GetHttpResponse<StateWithCitiesResponseDTO>(address);
            }
            catch (Exception)
            {
                throw new DataFetchException();
            }
        }

        public async Task<int> GetCountAsync()
        {
            try
            {
                var address = new Uri($"{_baseServerAddress}api/{CONTROLLER_NAME}/Count/");

                return await GetHttpResponse<int>(address);
            }
            catch (Exception)
            {
                throw new DataFetchException();
            }
        }
    }
}
