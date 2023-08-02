using AutoMapper;
using CountryInfo.Shared.DTOs.Responses;
using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Exceptions;
using CountryInfo.WebAPI.Extensions;
using CountryInfo.WebAPI.Repositories.Abstractions;
using CountryInfo.WebAPI.Services.Abstractions;
using CountryInfo.WebAPI.Specifications.Implementation;

namespace CountryInfo.WebAPI.Services.Implementation
{
    public class DefaultCityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        public DefaultCityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public async Task<IEnumerable<City>> GetAllAsync()
        {
            var cities = await _cityRepository.GetAllAsync();
            if (cities.IsNullOrEmpty())
                throw new DataNotFoundException();

            return cities;
        }

        public async Task<City> GetAsync(int cityId)
        {
            var city = await _cityRepository.GetAsync(cityId);
            if (city == null)
                throw new DataNotFoundException();

            return city;
        }

        public async Task<int> GetCountAsync()
        {
            return await _cityRepository.GetCountAsync();
        }

        public async Task<IEnumerable<City>> Search(string cityName)
        {
            var specification = new CityByCityNameSpecificaion(cityName);

            var cities = await _cityRepository.FilterBySpecificationAsync(specification);
            if (cities.IsNullOrEmpty())
                throw new DataNotFoundException();

            return cities;
        }
    }
}
