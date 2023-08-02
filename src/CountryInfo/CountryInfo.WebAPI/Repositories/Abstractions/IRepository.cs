using CountryInfo.WebAPI.Specifications.Abstractions;

namespace CountryInfo.WebAPI.Repositories.Abstractions
{
    public interface IRepository<TEntity, TId> where TEntity : class
    {
        Task<TEntity> GetAsync(TId id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task CreateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task<int> GetCountAsync();

        Task<int> GetCountBySpecificationAsync(ISpecification<TEntity> specification);
        Task<IEnumerable<TEntity>> FilterBySpecificationAsync(ISpecification<TEntity> specification);
    }
}
