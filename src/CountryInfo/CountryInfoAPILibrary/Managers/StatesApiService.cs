using CountryInfoAPILibrary.Models;
using Newtonsoft.Json;
using System.Net;

namespace CountryInfoAPILibrary.Managers
{
    public class StatesApiService : EntityManager<State>
    {
        public StatesApiService(string apiKey, string baseServerAddress) 
            : base(baseServerAddress, controllerName: "States") 
        {
            
        }

        // TODO Something...
    }
}
