# Country Info

## Репозиторий включает:
- <a href="https://github.com/kerminator-dev/Country-Info/tree/main/src/CountryInfo/CountryInfoAPI">ASP.NET Core 6 Country Info WEB API</a>
- <a href="https://github.com/kerminator-dev/Country-Info/tree/main/src/CountryInfo/CountryInfoAPILibrary">Библиотека классов для удобного взаимодействия с Country Info API</a>
- <a href="https://github.com/kerminator-dev/Country-Info/tree/main/src/CountryInfo/ConsoleClient">Тестовый консольный клиент</a>

## Country Info API - API-интерфейс, предоставляющий данные о:
- Странах (Countries)
- Регионах/штатах (States)
- Городах (Cities)

## API-Методы:
- Данные о странах:
  - /api/Countries/All                      - список всех стран
  - /api/Countries/Detail/{country_id}      - детальная данные о стране с id {country_id}, включает список штатов страны
  - /api/Countries/PhoneCode/{phone_code}   - список стран с телефонным кодом {phone_code}
  - /api/Countries/Count                    - общее количество стран

- Данные о регионах/штатах:
  - /api/States/All                         - список всех регионов/штатов
  - /api/States/Detail/{state_id}           - детальные данные о регионе/штате с id {state_id}, включает список городов штата
  - /api/States/Count                       - общее количество регионов

- Данные о городах
  - /api/Cities/All                         - список всех городов
  - /api/Cities/Detail/{city_id}            - детальные данные о городе с id {city_id}
  - /api.Cities/Count                       - общее количество городов

## Сущности
- Модели:
  - Страна:
  ```cs
  public class Country
  {
      [Key]
      [JsonProperty("id")]
      public int Id { get; set; }

      [JsonProperty("shortName")]
      public string ShortName { get; set; }

      [JsonProperty("name")]
      public string Name { get; set; }

      [JsonProperty("phoneCode")]
      public int PhoneCode { get; set; }

      [JsonProperty("states")]
      public virtual ICollection<State> States { get; set; }
  }
  ```
  - Регион:
  ```cs
  public class State
  {
      [Key]
      [JsonProperty("id")]
      public int Id { get; set; }

      [JsonProperty("name")]
      public string Name { get; set; }

      [JsonProperty("countryId")]
      public int CountryId { get; set; }

      [JsonProperty("cities")]
      public virtual ICollection<City> Cities { get; set; }
  }
  ```
  - Город:
  ```cs
  public class City
  {
      [Key]
      [JsonProperty("id")]
      public int Id { get; set; }

      [JsonProperty("name")]
      public string Name { get; set; }

      [JsonProperty("stateId")]
      public int StateId { get; set; }
  }
  ```
  
## Пример использования:
```cs
using CountryInfoAPILibrary;

CountryInfoAPI API = new CountryInfoAPI
(
    baseServerAddress: "https://localhost:####/",
    apiKey: String.Empty
);

Console.Write("Введите код телефона: ");

if (int.TryParse(Console.ReadLine(), out int phoneCode)
{
  var country = API.Countries.GetByPhoneCode(phoneCode).Result;
  
  if (country == null)
  {
    Console.WriteLine("Нет данных");
    return;
  }
  
  Console.WriteLine($"Страна: {country.Name}(country.ShortName)");
}
```
