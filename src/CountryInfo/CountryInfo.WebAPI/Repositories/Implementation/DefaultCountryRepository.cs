using CountryInfo.WebAPI.Data;
using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Repositories.Abstractions;

namespace CountryInfo.WebAPI.Repositories.Implementation
{
    public class DefaultCountryRepository : ICountryRepository
    {

        private readonly AppDbContext _dbContext;

        public DefaultCountryRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(Country country)
        {
            await _dbContext.Countries.AddAsync(country);

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Country country)
        {
            _dbContext.Countries.Remove(country);

            await _dbContext.SaveChangesAsync();
        }

        public Task<IEnumerable<Country>> GetAllAsync()
        {
            return Task.FromResult(_dbContext.Countries.AsEnumerable<Country>());
        }

        public async Task<Country> GetAsync(int id)
        {
            return await _dbContext.Countries.FindAsync(id);
        }

        public async Task UpdateAsync(Country country)
        {
            _dbContext.Countries.Update(country);

            await _dbContext.SaveChangesAsync();
        }
    }
}
