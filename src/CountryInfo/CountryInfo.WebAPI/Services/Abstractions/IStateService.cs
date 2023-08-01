using CountryInfo.WebAPI.Entities;

namespace CountryInfo.WebAPI.Services.Abstractions
{
    public interface IStateService
    {
        Task<IEnumerable<State>> GetAllAsync();
        Task<State> GetAsync(int stateId);
        Task<int> GetCountAsync();
    }
}
