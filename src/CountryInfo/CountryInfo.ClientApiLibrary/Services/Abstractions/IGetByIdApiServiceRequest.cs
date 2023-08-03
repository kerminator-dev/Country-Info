namespace CountryInfo.ClientApiLibrary.Services.Abstractions
{
    internal interface IGetByIdApiServiceRequest<TEntity>
    {
        Task<TEntity> GetByIdAsync(int id);
    }
}
