
using CountryInfo.ClientApiLibrary;

var apiService = new CountryInfoFacade
(
    baseServerAddress: "https://localhost:7046/"
);

// var cities = await API.Cities.GetAll();
var city = await apiService.Cities.GetByIdAsync(1);
var countOfCities = await apiService.Cities.GetCountAsync();

var countries = await apiService.Countries.GetAllAsync();
var country = await apiService.Countries.GetByIdAsync(10);
var countriesByPhoneCode = await apiService.Countries.GetByPhoneCodeAsync(7);
var countOfCountries = await apiService.Countries.GetCountAsync();

//var states = await API.States.GetAll();
var state = await apiService.States.GetByIdAsync(1);
var countOfStates = await apiService.States.GetCountAsync();

Console.WriteLine();