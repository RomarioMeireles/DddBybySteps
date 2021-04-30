using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Interface.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity:class
    {
        void Add(TEntity t);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity t);
        void Update(IEnumerable<TEntity> entities);
        void Delete(TEntity t);
        void Delete(IEnumerable<TEntity> entities);
        TEntity Find(Expression<Func<TEntity, bool>> t);
        IEnumerable<TEntity> GetAll();
        int SaveChanges();
    }
}
