using CountryInfo.WebAPI.Entities;

namespace CountryInfo.WebAPI.Services.Abstractions
{
    public interface ICountryService
    {
        Task<Country> GetAsync(int countryId);
        Task<IEnumerable<Country>> GetAllAsync();
        Task<IEnumerable<Country>> GetByPhoneCodeAsync(int phoneCode);
        Task<int> GetCountAsync();
    }
}
