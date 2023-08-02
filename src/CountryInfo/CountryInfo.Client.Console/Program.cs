using CountryInfoAPILibrary;

var apiService = new CountryInfoAPI
(
    baseServerAddress: "https://localhost:7046/"
);

// var cities = await API.Cities.GetAll();
var city = await apiService.Cities.GetDetails(1);
var countOfCities = await apiService.Cities.GetCount();

var countries = await apiService.Countries.GetAll();
var country = await apiService.Countries.GetDetails(10);
var countryByPhoneCode = await apiService.Countries.GetByPhoneCode(7);
var countOfCountries = await apiService.Countries.GetCount();

// var states = await API.States.GetAll();
var state = await apiService.States.GetDetails(1);
var countOfStates = await apiService.States.GetCount();

Console.WriteLine();