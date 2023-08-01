using AutoMapper;
using CountryInfo.Shared.DTOs.Responses;
using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Exceptions;
using CountryInfo.WebAPI.Extensions;
using CountryInfo.WebAPI.Repositories.Abstractions;
using CountryInfo.WebAPI.Services.Abstractions;
using CountryInfo.WebAPI.Specifications.Implementation;
using CountryInfo.WebAPI.ValidationStrategies.Implementation;

namespace CountryInfo.WebAPI.Services.Implementation
{
    public class DefaultCountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly PhoneCodeValidationStrategy _phoneCodeValidationStrategy;

        public DefaultCountryService(ICountryRepository countryRepository, PhoneCodeValidationStrategy phoneCodeValidationStrategy)
        {
            _countryRepository = countryRepository;
            _phoneCodeValidationStrategy = phoneCodeValidationStrategy;
        }

        public async Task<Country> GetAsync(int countryId)
        {
            var country = await _countryRepository.GetAsync(countryId);
            if (country == null)
                throw new DataNotFoundException();

            await _countryRepository.LoadStatesAsync(country);

            return country;
        }

        public async Task<IEnumerable<Country>> GetAllAsync()
        {
            var countries = await _countryRepository.GetAllAsync();
            if (countries.IsNullOrEmpty())
                throw new DataNotFoundException();

            return countries;
        }

        public async Task<IEnumerable<Country>> GetByPhoneCodeAsync(int phoneCode)
        {
            var isValidPhoneCode = _phoneCodeValidationStrategy.IsValid(phoneCode);
            if (!isValidPhoneCode)
                throw new WrongPhoneCodeException();

            var specification = new CountryByPhoneCodeSpecification(phoneCode);

            var countries = await _countryRepository.FilterBySpecificationAsync(specification);
            if (countries.IsNullOrEmpty())
                throw new DataNotFoundException();

            return countries;
        }

        public async Task<int> GetCountAsync()
        {
            return await _countryRepository.GetCountAsync();
        }
    }
}
