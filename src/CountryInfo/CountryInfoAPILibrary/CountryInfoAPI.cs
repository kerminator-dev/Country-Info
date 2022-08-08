using CountryInfoAPILibrary.Managers;

namespace CountryInfoAPILibrary
{
    public class CountryInfoAPI
    {
        private readonly string _apiKey;
        private readonly string _baseServerAddress;

        private readonly CountriesManager _countriesManager;
        private readonly StatesManager _statesManager;
        private readonly CitiesManager _citiesManager;

        public CountriesManager Countries => _countriesManager;
        public StatesManager States => _statesManager;
        public CitiesManager Cities => _citiesManager;

        public CountryInfoAPI(string baseServerAddress, string apiKey)
        {
            _baseServerAddress = baseServerAddress;
            _apiKey = apiKey;

            _countriesManager = new CountriesManager(apiKey, baseServerAddress);
            _statesManager = new StatesManager(apiKey, baseServerAddress);
            _citiesManager = new CitiesManager(apiKey, baseServerAddress);
        }
    }
}