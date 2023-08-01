using CountryInfo.WebAPI.Entities;

namespace CountryInfo.WebAPI.Repositories.Abstractions
{
    public interface ICountryRepository : IRepository<Country, int>
    {
        Task LoadStatesAsync(Country country);
    }
}
