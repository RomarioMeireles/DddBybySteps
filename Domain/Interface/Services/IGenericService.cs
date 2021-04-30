using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Interface.Services
{
    public interface IGenericService<T> where T:class
    {
        void Add(T t);
        void AddRange(IEnumerable<T> entities);
        void Update(T t);
        void Update(IEnumerable<T> entities);
        void Delete(T t);
        void Delete(IEnumerable<T> entities);
        T Find(Expression<Func<T, bool>> t);
        IEnumerable<T> GetAll();
        int SaveChanges();
    }
}
