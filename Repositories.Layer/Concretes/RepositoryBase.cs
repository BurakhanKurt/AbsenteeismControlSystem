using Microsoft.EntityFrameworkCore;
using Repositories.Layer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Layer.Concretes
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly AppDbContext _context;

        public RepositoryBase(AppDbContext context)
        {
            _context=context;
        }

        public IQueryable<T> GetAll(bool trackChanges) => 
            trackChanges ?
            _context.Set<T>().AsTracking():
            _context.Set<T>().AsNoTracking();

        public IQueryable<T> GetById(Expression<Func<T, bool>> expression, bool trackChanges) =>
            trackChanges ?
            _context.Set<T>().Where(expression).AsTracking():
            _context.Set<T>().Where(expression).AsNoTracking();

        public void Create(T entity) => _context.Set<T>().Add(entity);

        public void Delete(T entity) => _context.Set<T>().Remove(entity);

        public void Update(T entity) => _context.Set<T>().Update(entity);
    }
}
