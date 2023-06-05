
using System.Linq.Expressions;

namespace Repositories.Layer.Repositories.Abstracts
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> GetAll(bool trackChanges);

        // TODO neden list donuyor
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges);

        void Update(T entity);
        void Delete(T entity);
        void Create(T entity);
    }
}
