namespace CountryInfoAPILibrary.Services.Abstractions
{
    internal interface IGetCountApiServiceRequest<TEntity>
    {
        Task<int> GetCountAsync<TEntity>();
    }
}
