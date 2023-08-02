using CountryInfoAPILibrary.Models;
using Newtonsoft.Json;
using System.Net;

namespace CountryInfoAPILibrary.Managers
{
    public class CitiesApiService : EntityManager<City>
    {
        public CitiesApiService(string apiKey, string baseServerAddress)
            : base(baseServerAddress, controllerName: "Cities") 
        {
            
        }
        
        // TODO Something...
    }
}
