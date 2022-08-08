using CountryInfoAPILibrary.Models;
using Newtonsoft.Json;
using System.Net;

namespace CountryInfoAPILibrary.Managers
{
    public class CitiesManager : EntityManager<City>
    {
        public CitiesManager(string apiKey, string baseServerAddress)
            : base(baseServerAddress, apiKey, controllerName: "Cities") 
        {
            
        }
        
        // TODO Something...
    }
}
