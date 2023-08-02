using Newtonsoft.Json;
using System.Net;

namespace CountryInfoAPILibrary.Managers
{
    public abstract class BaseApiService<TEntity> where TEntity : class
    {
        protected readonly string _baseServerAddress;   // Адрес хоста
        protected readonly string _controllerName;      // Название API-Controller'а (например, Cities - https://localhost:xxxx/api/Cities/

        public BaseApiService(string baseServerAddress, string controllerName)
        {
            _baseServerAddress = baseServerAddress;
            _controllerName = controllerName;
        }

        // TODO: Сделать методы async

        /// <summary>
        /// Получить список всех <typeparamref name="T"/>
        /// </summary>
        /// <returns>Список всех <typeparamref name="T"/></returns>
        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            try
            {
                // Генерация адреса
                var address = new Uri($"{_baseServerAddress}api/{_controllerName}");

                // Возврат результата выполнения
                return await MakeGETRequest<IEnumerable<TEntity>>(address);
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
                // Генерация адреса
                var address = new Uri($"{_baseServerAddress}api/{_controllerName}/{id}");

                return await MakeGETRequest<TEntity>(address);
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
                // Генерация адреса
                var address = new Uri($"{_baseServerAddress}api/{_controllerName}/Count/");

                return await MakeGETRequest<int>(address);
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected async Task<TResult> MakeGETRequest<TResult>(Uri address)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    // Обращение к адресу и поолучение json-строки
                    var json = await webClient.DownloadStringTaskAsync(address);

                    // Десериализация json в <T>
                    var data = JsonConvert.DeserializeObject<TResult>(json);

                    // Возврат результата выполнения
                    return data;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
