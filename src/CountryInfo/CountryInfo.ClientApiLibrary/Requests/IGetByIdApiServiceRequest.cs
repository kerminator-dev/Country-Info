namespace CountryInfo.ClientApiLibrary.Requests
{
    public interface IGetByIdApiServiceRequest<TEntity>
    {
        Task<TEntity> GetByIdAsync(int id);
    }
}
