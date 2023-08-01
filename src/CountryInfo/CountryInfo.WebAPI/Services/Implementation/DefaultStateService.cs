using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Exceptions;
using CountryInfo.WebAPI.Extensions;
using CountryInfo.WebAPI.Repositories.Abstractions;
using CountryInfo.WebAPI.Services.Abstractions;

namespace CountryInfo.WebAPI.Services.Implementation
{
    public class DefaultStateService : IStateService
    {
        private readonly IStateRepository _stateRepository;

        public DefaultStateService(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        public async Task<State> GetAsync(int stateId)
        {
            var state = await _stateRepository.GetAsync(stateId);
            if (state == null)
                throw new DataNotFoundException();

            await _stateRepository.LoadCitiesAsync(state);

            return state;
        }

        public async Task<IEnumerable<State>> GetAllAsync()
        {
            var states = await _stateRepository.GetAllAsync();
            if (states.IsNullOrEmpty())
                throw new DataNotFoundException();

            return states;
        }

        public async Task<int> GetCountAsync()
        {
            return await _stateRepository.GetCountAsync();
        }
    }
}
