using CountryInfo.WebAPI.Data;
using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Repositories.Abstractions;

namespace CountryInfo.WebAPI.Repositories.Implementation
{
    public class DefaultCityRepository : ICityRepository
    {
        private readonly AppDbContext _dbContext;

        public DefaultCityRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task CreateAsync(City city)
        {
            await _dbContext.Cities.AddAsync(city);

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(City city)
        {
            _dbContext.Cities.Remove(city);

            await _dbContext.SaveChangesAsync();
        }

        public Task<IEnumerable<City>> GetAllAsync()
        {
            return Task.FromResult(_dbContext.Cities.AsEnumerable<City>());
        }

        public async Task<City> GetAsync(int id)
        {
            return await _dbContext.Cities.FindAsync(id);
        }

        public async Task UpdateAsync(City city)
        {
            _dbContext.Cities.Update(city);

            await _dbContext.SaveChangesAsync();
        }
    }
}
