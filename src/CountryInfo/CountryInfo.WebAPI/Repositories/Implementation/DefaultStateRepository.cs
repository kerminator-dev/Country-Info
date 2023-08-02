using CountryInfo.WebAPI.Data;
using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Repositories.Abstractions;
using CountryInfo.WebAPI.Specifications.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace CountryInfo.WebAPI.Repositories.Implementation
{
    public class DefaultStateRepository : IStateRepository
    {
        private readonly AppDbContext _dbContext;

        public DefaultStateRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(State state)
        {
            await _dbContext.States.AddAsync(state);

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(State state)
        {
            _dbContext.States.Remove(state);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<State>> FilterBySpecificationAsync(ISpecification<State> specification)
        {
            return await _dbContext
                         .States
                         .Where(specification.ToExpression())
                         .ToListAsync();
        }

        public async Task<IEnumerable<State>> GetAllAsync()
        {
            return await _dbContext.States.ToListAsync();
        }

        public async Task<State> GetAsync(int id)
        {
            return await _dbContext.States.FindAsync(id);
        }

        public async Task<int> GetCountAsync()
        {
            return await _dbContext.States.CountAsync();
        }

        public async Task<int> GetCountBySpecificationAsync(ISpecification<State> specification)
        {
            return await _dbContext
                         .States
                         .Where(specification.ToExpression())
                         .CountAsync();
        }

        public async Task LoadAsync<TProperty>(State entity, System.Linq.Expressions.Expression<Func<State, TProperty>> property) where TProperty : class
        {
            await _dbContext.Entry(entity).Reference(property).LoadAsync();
        }

        public async Task LoadCitiesAsync(State state)
        {
            await _dbContext.Entry(state).Collection(s => s.Cities).LoadAsync();
        }

        public async Task UpdateAsync(State state)
        {
            _dbContext.States.Update(state);

            await _dbContext.SaveChangesAsync();
        }
    }
}
