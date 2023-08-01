using CountryInfo.WebAPI.Entities;

namespace CountryInfo.WebAPI.Repositories.Abstractions
{
    public interface IStateRepository
    {
        Task<State> GetAsync(int id);
        Task<IEnumerable<State>> GetAllAsync();
        Task CreateAsync(State state);
        Task DeleteAsync(State state);
        Task UpdateAsync(State state);
    }
}
