using CountryInfo.WebAPI.Entities;

namespace CountryInfo.WebAPI.Repositories.Abstractions
{
    public interface IStateRepository : IRepository<State, int>
    {
        Task LoadCitiesAsync(State state);
    }
}
