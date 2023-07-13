
using System.Linq.Expressions;

namespace Repositories.Repositories.Abstracts
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> GetAll(bool trackChanges);
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        void Update(T entity);
        void Delete(T entity);
        void Create(T entity);
        Task CreateAsync(T entity);
        Task<int> CountAsync(Expression<Func<T, bool>> expression);
    }
}
