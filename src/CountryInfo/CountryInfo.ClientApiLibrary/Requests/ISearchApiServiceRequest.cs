namespace CountryInfo.ClientApiLibrary.Requests
{
    public interface ISearchApiServiceRequest<TResponse, TValue>
    {
        Task<IEnumerable<TResponse>> SearchAsync(TValue value);
    }
}
