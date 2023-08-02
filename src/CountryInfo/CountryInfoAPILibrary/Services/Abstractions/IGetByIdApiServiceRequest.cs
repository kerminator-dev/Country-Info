namespace CountryInfoAPILibrary.Services.Abstractions
{
    internal interface IGetByIdApiService<TEntity>
    {
        Task<TEntity> GetByIdAsync(int id);
    }
}
