namespace CountryInfo.WebAPI.Exceptions
{
    public sealed class WrongPhoneCodeException : Exception
    {
        public WrongPhoneCodeException(string message = "Wrong phone code!") : base(message)
        {

        }
    }
}
