using CountryInfo.WebAPI.ValidationStrategies.Abstractions;

namespace CountryInfo.WebAPI.ValidationStrategies.Implementation
{
    /// <summary>
    /// Проверка на длину кода страны
    /// </summary>
    public class PhoneCodeValidationStrategy : IValidationStrategy<int>
    {
        private const int MIN_PHONE_CODE = 0;

        public bool IsValid(int value)
        {
            // Можно добавить доп. условия, если сильно захотеть
            // Проверки на отрицательное значение, мне кажется, будет достаточно

            return value >= MIN_PHONE_CODE;
        }
    }
}
