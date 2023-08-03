namespace CountryInfoAPILibrary.Services.Abstractions
{
    internal interface ISearchApiServiceRequest<TResponse, TValue>
    {
        Task<IEnumerable<TResponse>> SearchAsync(TValue value);
    }
}
