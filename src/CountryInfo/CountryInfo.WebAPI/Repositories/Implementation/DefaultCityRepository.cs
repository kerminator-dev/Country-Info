using CountryInfo.WebAPI.Data;
using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Repositories.Abstractions;
using CountryInfo.WebAPI.Specifications.Abstractions;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IEnumerable<City>> FilterBySpecificationAsync(ISpecification<City> criteria)
        {
            return await _dbContext.Cities.Where(criteria.ToExpression()).ToListAsync();
        }

        public async Task<IEnumerable<City>> GetAllAsync()
        {
            return await _dbContext.Cities.ToListAsync();
        }

        public async Task<City> GetAsync(int id)
        {
            return await _dbContext.Cities.FindAsync(id);
        }

        public async Task<int> GetCountAsync()
        {
            return await _dbContext.Cities.CountAsync();
        }

        public async Task UpdateAsync(City city)
        {
            _dbContext.Cities.Update(city);

            await _dbContext.SaveChangesAsync();
        }
    }
}
