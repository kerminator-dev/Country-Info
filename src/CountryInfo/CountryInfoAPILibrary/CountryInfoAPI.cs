using CountryInfoAPILibrary.Managers;

namespace CountryInfoAPILibrary
{
    public class CountryInfoAPI
    {
        private readonly string _baseServerAddress;

        private readonly CountriesApiService _countriesManager;
        private readonly StatesApiService _statesManager;
        private readonly CitiesApiService _citiesManager;

        public CountriesApiService Countries => _countriesManager;
        public StatesApiService States => _statesManager;
        public CitiesApiService Cities => _citiesManager;

        public CountryInfoAPI(string baseServerAddress)
        {
            _baseServerAddress = baseServerAddress;

            _countriesManager = new CountriesApiService(baseServerAddress);
            _statesManager = new StatesApiService(baseServerAddress);
            _citiesManager = new CitiesApiService(baseServerAddress);
        }
    }
}