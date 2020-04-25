using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ShopApp.DataAccess.Concrete.EfCore.Repository
{
    public class EfCoreRepository<TEntity> : IRepository<TEntity>
                                  where TEntity : class
    {
        private readonly DbContext _dbContext;

        public EfCoreRepository(ShopContext shopContext)
        {
            _dbContext = shopContext;
        }

        public TEntity GetById(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public TEntity GetByFilter(Expression<Func<TEntity, bool>> filter)
        {
            return _dbContext.Set<TEntity>().Where(filter).SingleOrDefault();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> GetListByFilter(Expression<Func<TEntity, bool>> filter)
        {
            return _dbContext.Set<TEntity>().Where(filter).ToList();
        }

        public void Add(TEntity entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");

                _dbContext.Set<TEntity>().Add(entity);
            }
            catch (Exception ex)
            {
                //TODO:Should be logging
                throw;
            }
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("entities");

                foreach (var entity in entities)
                _dbContext.Set<TEntity>().Add(entity);
            }
            catch (Exception ex)
            {
                //TODO:Should be logging
                throw;
            }
        }

        public void Delete(TEntity entity)
        {
            try
            {
                _dbContext.Remove(entity);
            }
            catch (Exception ex)
            {
                //TODO:Should be logging
                throw;
            }
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            try
            {
                foreach (var entity in entities)
                    _dbContext.Remove(entity);
            }
            catch (Exception ex)
            {
                //TODO:Should be logging
                throw;
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
            }
            catch (Exception ex)
            {
                //TODO:Should be logging
                throw;
            }
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            try
            {
                foreach (var entity in entities)
                    _dbContext.Entry(entity).State = EntityState.Modified;
            }
            catch (Exception ex)
            {
                //TODO:Should be logging
                throw;
            }
        }
    }
}
