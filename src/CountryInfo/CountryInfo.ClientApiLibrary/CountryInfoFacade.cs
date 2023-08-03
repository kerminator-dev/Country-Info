using CountryInfo.ClientApiLibrary.Exceptions;
using CountryInfo.ClientApiLibrary.Services.Implementation;
using CountryInfo.Shared.DTOs.Responses;

namespace CountryInfo.ClientApiLibrary
{
    public class CountryInfoFacade 
    {
        private readonly CountryApiService _countryService;
        private readonly StateApiService _stateService;
        private readonly CityApiService _cityService;

        public CountryInfoFacade(string baseServerAddress)
        {
            _countryService = new CountryApiService(baseServerAddress);
            _stateService = new StateApiService(baseServerAddress);
            _cityService = new CityApiService(baseServerAddress);
        }

        public async Task<IEnumerable<CountryResponseDTO>> GetAllCountriesAsync()
        {
            try
            {
                return await _countryService.GetAllAsync();
            }
            catch (Exception)
            {
                throw new DataFetchException();
            }
        }
    }
}