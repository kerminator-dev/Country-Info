using CountryInfoAPILibrary;

CountryInfoAPI API = new CountryInfoAPI
(
    baseServerAddress: "https://localhost:7046/",
    apiKey: String.Empty
);

var cities = API.Cities.GetAll().Result;
var city = API.Cities.GetDetail(1).Result;
var countOfCities = API.Cities.GetCount().Result;

var countries = API.Countries.GetAll().Result;
var country = API.Countries.GetDetail(10).Result;
var countryByPhoneCode = API.Countries.GetByPhoneCode(7).Result;
var countOfCountries = API.Countries.GetCount().Result;

var states = API.States.GetAll().Result;
var state = API.States.GetDetail(1).Result;
var countOfStates = API.States.GetCount().Result;

Console.WriteLine();