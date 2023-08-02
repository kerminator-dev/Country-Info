using CountryInfoAPILibrary.Models;
using Newtonsoft.Json;
using System.Net;

namespace CountryInfoAPILibrary.Managers
{
    public class CitiesApiService : BaseApiService<City>
    {
        public CitiesApiService(string baseServerAddress)
            : base(baseServerAddress, controllerName: "Cities") 
        {
            
        }
        
        // TODO Something...
    }
}
