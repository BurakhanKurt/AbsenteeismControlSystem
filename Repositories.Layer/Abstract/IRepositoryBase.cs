using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Layer.Abstract
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> GetAll(bool trackChanges);
        IQueryable<T> GetById(Expression<Func<T,bool>> expression,bool trackChanges);
        void Update(T entity);
        void Delete(T entity);
        void Create(T entity);
    }
}
