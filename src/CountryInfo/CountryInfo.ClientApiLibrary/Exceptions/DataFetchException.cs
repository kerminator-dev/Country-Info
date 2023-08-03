namespace CountryInfo.ClientApiLibrary.Exceptions
{
    internal class DataFetchException : Exception
    {
        public DataFetchException(string message = "Не удалось получить данные") : base(message) 
        {
            
        }
    }
}
