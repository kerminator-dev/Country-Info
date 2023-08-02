using CountryInfoAPILibrary.Models;

namespace CountryInfoAPILibrary.Managers
{
    public class StatesApiService : BaseApiService<State>
    {
        public StatesApiService(string baseServerAddress) 
            : base(baseServerAddress, controllerName: "States") 
        {
            
        }

        // TODO Something...
    }
}
