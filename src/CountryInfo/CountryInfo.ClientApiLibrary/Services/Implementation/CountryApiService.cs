using CountryInfo.ClientApiLibrary.Exceptions;
using CountryInfo.ClientApiLibrary.Services.Abstractions;
using CountryInfo.Shared.DTOs.Responses;

namespace CountryInfo.ClientApiLibrary.Services.Implementation
{
    internal class CountryApiService : BaseApiService, ICountryApiService
    {
        private const string CONTROLLER_NAME = "Countries";
        private readonly string _baseServerAddress;

        public CountryApiService(string baseServerAddress)
        {
            _baseServerAddress = baseServerAddress;
        }

        public async Task<IEnumerable<CountryResponseDTO>> GetAllAsync()
        {
            try
            {
                var address = new Uri($"{_baseServerAddress}api/{CONTROLLER_NAME}");

                return await GetHttpResponse<IEnumerable<CountryResponseDTO>>(address);
            }
            catch (Exception)
            {
                throw new DataFetchException();
            }
        }

        public async Task<CountryWithStatesResponseDTO> GetByIdAsync(int id)
        {
            try
            {
                var address = new Uri($"{_baseServerAddress}api/{CONTROLLER_NAME}/{id}");

                return await GetHttpResponse<CountryWithStatesResponseDTO> (address);
            }
            catch (Exception)
            {
                throw new DataFetchException();
            }
        }

        public async Task<IEnumerable<CountryResponseDTO>> GetByPhoneCodeAsync(int phoneCode)
        {
            try
            {
                var address = new Uri($"{_baseServerAddress}api/{CONTROLLER_NAME}/PhoneCode={phoneCode}");

                return await GetHttpResponse<IEnumerable<CountryResponseDTO>>(address);
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
