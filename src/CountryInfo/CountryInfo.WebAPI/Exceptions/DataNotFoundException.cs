namespace CountryInfo.WebAPI.Exceptions
{
    public sealed class DataNotFoundException : Exception
    {
        public DataNotFoundException(string message = "Data not found!") : base(message)
        {

        }
    }
}
