using CountryInfoAPILibrary.Models;
using System.Net;

namespace CountryInfoAPILibrary.Managers
{
    public class CountriesApiService : BaseApiService<Country>
    {
        public CountriesApiService(string baseServerAddress)
            : base(baseServerAddress, controllerName: "Countries") 
        {
            
        }

        /// <summary>
        /// Получить данные о стране по коду телефона
        /// </summary>
        /// <param name="phoneCode"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Country>> GetByPhoneCode(int phoneCode)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    Uri address = new Uri($"{_baseServerAddress}api/{_controllerName}/PhoneCode={phoneCode}");

                    return await MakeGETRequest<IEnumerable<Country>>(address);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
