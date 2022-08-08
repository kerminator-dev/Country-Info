using CountryInfoAPILibrary.Models;
using Newtonsoft.Json;
using System.Net;

namespace CountryInfoAPILibrary.Managers
{
    public class CountriesManager : EntityManager<Country>
    {
        public CountriesManager(string apiKey, string baseServerAddress)
            : base(baseServerAddress, apiKey, controllerName: "Countries") 
        {
            
        }

        /// <summary>
        /// Получить данные о стране по коду телефона
        /// </summary>
        /// <param name="phoneCode"></param>
        /// <returns></returns>
        public Responce<IReadOnlyList<Country>> GetByPhoneCode(int phoneCode)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    Uri address = new Uri($"{_baseServerAddress}api/{_controllerName}/PhoneCode/{phoneCode}");
                    var json = webClient.DownloadString(address);

                    var countries = JsonConvert.DeserializeObject<List<Country>>(json);

                    return new Responce<IReadOnlyList<Country>>
                    (
                        result: countries,
                        exception: null
                    );
                }
            }
            catch (Exception ex)
            {
                return new Responce<IReadOnlyList<Country>>
                (
                    result: null,
                    exception: ex
                );
            }
        }
    }
}
