namespace CountryInfo.ClientApiLibrary.Services.Abstractions
{
    internal interface IGetCountApiServiceRequest<TEntity>
    {
        Task<int> GetCountAsync<TEntity>();
    }
}
