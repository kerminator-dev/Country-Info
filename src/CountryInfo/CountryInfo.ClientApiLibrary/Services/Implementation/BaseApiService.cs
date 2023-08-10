using Newtonsoft.Json;
using System.Net;

namespace CountryInfo.ClientApiLibrary.Services.Implementation
{
    internal abstract class BaseApiService
    {
        protected virtual async Task<TResult> GetHttpResponse<TResult>(Uri address)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    var json = await webClient.DownloadStringTaskAsync(address);

                    return JsonConvert.DeserializeObject<TResult>(json);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
