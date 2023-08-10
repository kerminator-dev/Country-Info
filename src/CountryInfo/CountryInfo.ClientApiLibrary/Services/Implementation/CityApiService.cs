using CountryInfo.ClientApiLibrary.Exceptions;
using CountryInfo.ClientApiLibrary.Services.Abstractions;
using CountryInfo.Shared.DTOs.Responses;

namespace CountryInfo.ClientApiLibrary.Services.Implementation
{
    internal class CityApiService : BaseApiService, ICityApiService
    {
        private const string CONTROLLER_NAME = "Cities";
        private readonly string _baseServerAddress;

        public CityApiService(string baseServerAddress)
        {
            _baseServerAddress = baseServerAddress;
        }

        public async Task<CityResponseDTO> GetByIdAsync(int id)
        {
            try
            {
                var address = new Uri($"{_baseServerAddress}api/{CONTROLLER_NAME}/{id}");

                return await GetHttpResponse<CityResponseDTO>(address);
            }
            catch (Exception)
            {
                throw new DataFetchException();
            }
        }

        public async Task<IEnumerable<CityResponseDTO>> SearchAsync(string value)
        {
            try
            {
                var address = new Uri($"{_baseServerAddress}api/{CONTROLLER_NAME}/Search={value}");

                return await GetHttpResponse<IEnumerable<CityResponseDTO>>(address);
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
