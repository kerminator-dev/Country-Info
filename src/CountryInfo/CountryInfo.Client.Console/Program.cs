
using CountryInfo.ClientApiLibrary;
using CountryInfo.Shared.DTOs.Responses;

var apiService = new CountryInfoApiService
(
    baseServerAddress: "https://localhost:7046/"
);

var city = await apiService.Cities.GetByIdAsync(1);
var countOfCities = await apiService.Cities.GetCountAsync();

var countries = await apiService.Countries.GetAllAsync();
var country = await apiService.Countries.GetByIdAsync(10);
var countriesByPhoneCode = await apiService.Countries.GetByPhoneCodeAsync(7);
var countOfCountries = await apiService.Countries.GetCountAsync();

var state = await apiService.States.GetByIdAsync(1);
var countOfStates = await apiService.States.GetCountAsync();

Console.Read();