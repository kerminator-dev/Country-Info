using CountryInfoAPILibrary.Models;
using Newtonsoft.Json;
using System.Net;

namespace CountryInfoAPILibrary.Managers
{
    public class StatesManager : EntityManager<State>
    {
        public StatesManager(string apiKey, string baseServerAddress) 
            : base(baseServerAddress, apiKey, controllerName: "States") 
        {
            
        }

        // TODO Something...
    }
}
