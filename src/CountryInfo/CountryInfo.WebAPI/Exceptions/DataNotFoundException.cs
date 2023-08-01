namespace CountryInfo.WebAPI.Exceptions
{
    public class DataNotFoundException : Exception
    {
        public DataNotFoundException(string message = "Data not found!") : base(message)
        {

        }
    }
}
