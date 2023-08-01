using CountryInfo.WebAPI.Data;
using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Repositories.Abstractions;

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

        public Task<IEnumerable<State>> GetAllAsync()
        {
            return Task.FromResult(_dbContext.States.AsEnumerable<State>());
        }

        public async Task<State> GetAsync(int id)
        {
            return await _dbContext.States.FindAsync(id);
        }

        public async Task UpdateAsync(State state)
        {
            _dbContext.States.Update(state);

            await _dbContext.SaveChangesAsync();
        }
    }
}
