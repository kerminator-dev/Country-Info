namespace CountryInfo.WebAPI.ValidationStrategies.Abstractions
{
    public interface IValidationStrategy<T>
    {
        bool IsValid(T value);
    }
}
