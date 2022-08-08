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
