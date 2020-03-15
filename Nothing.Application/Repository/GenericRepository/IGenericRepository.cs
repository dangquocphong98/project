
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Nothing.Application.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void AddRange(List<TEntity> entities);

        void Update(TEntity entity);
        void UpdateRange(List<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(List<TEntity> entities);

        int Count();

       
        TEntity GetSingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(int id);
        List<TEntity> GetAll();
    }
}
