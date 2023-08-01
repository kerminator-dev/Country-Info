using CountryInfo.WebAPI.Data;
using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Repositories.Abstractions;
using CountryInfo.WebAPI.Specifications.Abstractions;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IEnumerable<Country>> FilterBySpecificationAsync(ISpecification<Country> criteria)
        {
            return await _dbContext.Countries.Where(criteria.ToExpression()).ToListAsync();
        }

        public async Task<IEnumerable<Country>> GetAllAsync()
        {
            return await _dbContext.Countries.ToListAsync<Country>();
        }

        public async Task<Country> GetAsync(int id)
        {
            return await _dbContext.Countries.FindAsync(id);
        }

        public async Task<int> GetCountAsync()
        {
            return await _dbContext.Countries.CountAsync();
        }



        public async Task LoadStatesAsync(Country country)
        {
            await _dbContext.Entry(country).Collection(c => c.States).LoadAsync();
        }

        public async Task UpdateAsync(Country country)
        {
            _dbContext.Countries.Update(country);

            await _dbContext.SaveChangesAsync();
        }
    }
}
