using CountryInfo.WebAPI.Entities;

namespace CountryInfo.WebAPI.Repositories.Abstractions
{
    public interface ICountryRepository
    {
        Task<Country> GetAsync(int id);
        Task<IEnumerable<Country>> GetAllAsync();
        Task CreateAsync(Country country);
        Task DeleteAsync(Country country);
        Task UpdateAsync(Country country);
    }
}
