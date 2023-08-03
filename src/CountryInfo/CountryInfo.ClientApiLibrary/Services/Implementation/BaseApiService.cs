using CountryInfo.ClientApiLibrary.Services.Abstractions;
using Newtonsoft.Json;
using System.Net;

namespace CountryInfo.ClientApiLibrary.Services.Implementation
{
    internal class BaseApiService<TEntity> : IGetAllApiServiceRequest<TEntity> where TEntity : class
    {
        protected readonly string _baseServerAddress;   // Адрес хоста
        protected readonly string _controllerName;      // Название API-Controller'а (например, Cities - https://localhost:xxxx/api/Cities/

        public BaseApiService(string baseServerAddress, string controllerName)
        {
            _baseServerAddress = baseServerAddress;
            _controllerName = controllerName;
        }

        protected static async Task<TResult> MakeGETRequest<TResult>(Uri address)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    var json = await webClient.DownloadStringTaskAsync(address);

                    var data = JsonConvert.DeserializeObject<TResult>(json);

                    return data;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Получить данные о <typeparamref name="TEntity"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Объект <typeparamref name="TEntity"/></returns>
        public virtual async Task<TEntity> GetDetails(int id)
        {
            try
            {
                var address = new Uri($"{_baseServerAddress}api/{_controllerName}/{id}");

                return await BaseApiService<TEntity>.MakeGETRequest<TEntity>(address);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Получить общее количество <typeparamref name="TEntity"/>
        /// </summary>
        /// <returns>Общее количество объектов <typeparamref name="TEntity"/></returns>
        public virtual async Task<int> GetCount()
        {
            try
            {
                var address = new Uri($"{_baseServerAddress}api/{_controllerName}/Count/");

                return await BaseApiService<TEntity>.MakeGETRequest<int>(address);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
