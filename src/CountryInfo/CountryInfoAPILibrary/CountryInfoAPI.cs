using CountryInfoAPILibrary.Managers;

namespace CountryInfoAPILibrary
{
    public class CountryInfoAPI
    {
        private readonly string _apiKey;
        private readonly string _baseServerAddress;

        private readonly CountriesApiService _countriesManager;
        private readonly StatesApiService _statesManager;
        private readonly CitiesApiService _citiesManager;

        public CountriesApiService Countries => _countriesManager;
        public StatesApiService States => _statesManager;
        public CitiesApiService Cities => _citiesManager;

        public CountryInfoAPI(string baseServerAddress, string apiKey)
        {
            _baseServerAddress = baseServerAddress;
            _apiKey = apiKey;

            _countriesManager = new CountriesApiService(apiKey, baseServerAddress);
            _statesManager = new StatesApiService(apiKey, baseServerAddress);
            _citiesManager = new CitiesApiService(apiKey, baseServerAddress);
        }
    }
}