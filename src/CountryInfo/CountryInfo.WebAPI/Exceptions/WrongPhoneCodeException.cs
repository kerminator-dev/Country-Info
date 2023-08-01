namespace CountryInfo.WebAPI.Exceptions
{
    public class WrongPhoneCodeException : Exception
    {
        public WrongPhoneCodeException(string message = "Wrong phone code!") : base(message)
        {

        }
    }
}
