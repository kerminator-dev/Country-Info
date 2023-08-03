using CountryInfoAPILibrary.Exceptions;
using CountryInfoAPILibrary.Models;
using CountryInfoAPILibrary.Services.Implementation;

namespace CountryInfoAPILibrary
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

        public async Task<IEnumerable<Country>> GetAllCountriesAsync()
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