namespace CountryInfo.ClientApiLibrary.Requests
{
    public interface IGetCountApiServiceRequest
    {
        Task<int> GetCountAsync();
    }
}
