using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Nothing.Application.Repository.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;
        protected readonly DbSet<TEntity> _entities;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }

        public virtual void Add(TEntity entity)
        {
            _entities.Add(entity);
        }

        public virtual void AddRange(List<TEntity> entities)
        {
            _entities.AddRange(entities);
        }


        public virtual void Update(TEntity entity)
        {
            _entities.Update(entity);
        }

        public virtual void UpdateRange(List<TEntity> entities)
        {
            _entities.UpdateRange(entities);
        }
        public virtual void Remove(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public virtual void RemoveRange(List<TEntity> entities)
        {
            _entities.RemoveRange(entities);
        }


        public virtual int Count()
        {
            return _entities.Count();
        }


      

        public virtual TEntity GetSingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.SingleOrDefault(predicate);
        }

        public virtual TEntity Get(int id)
        {
            return _entities.Find(id);
        }

        public virtual List<TEntity> GetAll()
        {
            return _entities.ToList();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
