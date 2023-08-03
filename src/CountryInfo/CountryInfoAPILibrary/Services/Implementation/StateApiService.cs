using CountryInfoAPILibrary.Models;

namespace CountryInfoAPILibrary.Services.Implementation
{
    internal class StateApiService : BaseApiService<State>
    {
        private const string CONTROLLER_NAME = "States";

        public StateApiService(string baseServerAddress) : base(baseServerAddress, CONTROLLER_NAME)
        {

        }

        public async Task<IEnumerable<State>> GetAllAsync()
        {
            try
            {
                var address = new Uri($"{_baseServerAddress}api/{_controllerName}");

                return await MakeGETRequest<IEnumerable<State>>(address);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
