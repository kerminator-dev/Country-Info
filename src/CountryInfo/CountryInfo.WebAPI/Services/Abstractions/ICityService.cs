using CountryInfo.WebAPI.Entities;

namespace CountryInfo.WebAPI.Services.Abstractions
{
    public interface ICityService
    {
        Task<City> GetAsync(int cityId);

        Task<IEnumerable<City>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<IEnumerable<City>> Search(string cityName);
    }
}
