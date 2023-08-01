using CountryInfo.WebAPI.Entities;

namespace CountryInfo.WebAPI.Repositories.Abstractions
{
    public interface ICityRepository
    {
        Task<City> GetAsync(int id);
        Task<IEnumerable<City>> GetAllAsync();
        Task CreateAsync(City city);
        Task DeleteAsync(City city);
        Task UpdateAsync(City city);
    }
}
