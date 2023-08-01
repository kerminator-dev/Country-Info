using CountryInfoAPILibrary.Models;
using Newtonsoft.Json;
using System.Net;

namespace CountryInfoAPILibrary.Managers
{
    public abstract class EntityManager<T> where T : class
    {
        protected readonly string _baseServerAddress;   // Адрес хоста
        protected readonly string _controllerName;      // Название API-Controller'а (например, Cities - https://localhost:xxxx/api/Cities/

        public EntityManager(string baseServerAddress, string controllerName)
        {
            _baseServerAddress = baseServerAddress;
            _controllerName = controllerName;
        }

        // TODO: Сделать методы async

        /// <summary>
        /// Получить список всех <typeparamref name="T"/>
        /// </summary>
        /// <returns>Список всех <typeparamref name="T"/></returns>
        public virtual Responce<IReadOnlyList<T>> GetAll()
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    // Генерация адреса
                    var address = new Uri($"{_baseServerAddress}api/{_controllerName}/All");

                    // Обращение к адресу и поолучение json-строки
                    var json = webClient.DownloadString(address);

                    // Десериализация json в <T>
                    var result = JsonConvert.DeserializeObject<List<T>>(json);

                    // Возврат результата выполнения
                    return new Responce<IReadOnlyList<T>>
                    (
                        result: result,
                        exception: null
                    );
                }
            }
            catch (Exception ex)
            {
                return new Responce<IReadOnlyList<T>>
                (
                    result: null,
                    exception: ex
                );
            }
        }

        /// <summary>
        /// Получить данные о <typeparamref name="T"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Объект <typeparamref name="T"/></returns>
        public virtual Responce<T> GetDetail(int id)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    // Генерация адреса
                    var address = new Uri($"{_baseServerAddress}api/{_controllerName}/Detail/{id}");

                    // Обращение к адресу и поолучение json-строки
                    var json = webClient.DownloadString(address);

                    // Десериализация json в <T>
                    var result = JsonConvert.DeserializeObject<T>(json);

                    // Возврат результата выполнения
                    return new Responce<T>
                    (
                        result: result,
                        exception: null
                    );
                }
            }
            catch (Exception ex)
            {
                return new Responce<T>
                (
                    result: null,
                    exception: ex
                );
            }
        }

        /// <summary>
        /// Получить общее количество <typeparamref name="T"/>
        /// </summary>
        /// <returns>Общее количество объектов <typeparamref name="T"/></returns>
        public virtual Responce<int> GetCount()
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    // Генерация адреса
                    var address = new Uri($"{_baseServerAddress}api/{_controllerName}/Count/");

                    // Обращение к адресу и поолучение json-строки
                    var json = webClient.DownloadString(address);

                    // Десериализация json в <T>
                    int count = JsonConvert.DeserializeObject<int>(json);

                    // Возврат результата выполнения
                    return new Responce<int>
                    (
                        result: count,
                        exception: null
                    );
                }
            }
            catch (Exception ex)
            {
                return new Responce<int>
                (
                    result: -1, // Ошибка выполнения
                    exception: ex
                );
            }
        }
    }
}
