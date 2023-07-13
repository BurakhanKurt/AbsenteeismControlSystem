using Microsoft.EntityFrameworkCore;
using Repositories.Repositories.Abstracts;
using System.Linq.Expressions;

namespace Repositories.Repositories.Concretes
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly AppDbContext _context;

        public RepositoryBase(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> GetAll(bool trackChanges) =>
            trackChanges ?
            _context.Set<T>().AsTracking() :
            _context.Set<T>().AsNoTracking();

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            trackChanges ?
            _context.Set<T>().Where(expression).AsTracking() :
            _context.Set<T>().Where(expression).AsNoTracking();
        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression) => 
            await _context.Set<T>().AnyAsync(expression);

        public async Task CreateAsync(T entity) => await _context.Set<T>().AddAsync(entity);
        public void Create(T entity) => _context.Set<T>().Add(entity);
        public void Delete(T entity) => _context.Set<T>().Remove(entity);
        public void Update(T entity) => _context.Set<T>().Update(entity);
        public async Task<int> CountAsync(Expression<Func<T, bool>> expression) => 
            await _context.Set<T>().CountAsync(expression);

    }
}
