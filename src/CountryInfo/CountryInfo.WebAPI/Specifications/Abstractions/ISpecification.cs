using System.Linq.Expressions;

namespace CountryInfo.WebAPI.Specifications.Abstractions
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T entity);

        Expression<Func<T, bool>> ToExpression();
    }
}
