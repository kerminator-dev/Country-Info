using CountryInfo.ClientApiLibrary.Exceptions;
using CountryInfo.ClientApiLibrary.Services.Abstractions;
using CountryInfo.ClientApiLibrary.Services.Implementation;
using CountryInfo.Shared.DTOs.Responses;

namespace CountryInfo.ClientApiLibrary
{
    public class CountryInfoFacade 
    {
        private readonly ICountryApiService _countryService;
        private readonly IStateApiService _stateService;
        private readonly ICityApiService _cityService;

        public ICountryApiService Countries => _countryService;
        public IStateApiService States => _stateService;
        public ICityApiService Cities => _cityService;

        public CountryInfoFacade(string baseServerAddress)
        {
            _countryService = new CountryApiService(baseServerAddress);
            _stateService = new StateApiService(baseServerAddress);
            _cityService = new CityApiService(baseServerAddress);
        }
    }
}