using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public class EfCoreRepository<TEntity, TContext> : IRepository<TEntity>
                                  where TEntity : class
                                  where TContext : DbContext, new()
    {
        public TEntity GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public TEntity GetByFilter(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).SingleOrDefault();
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public IEnumerable<TEntity> GetListByFilter(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Add(TEntity entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");

                using (var context = new TContext())
                {
                    context.Set<TEntity>().Add(entity);
                    context.SaveChanges();
                }
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

                using (var context = new TContext())
                {
                    foreach (var entity in entities)
                        context.Set<TEntity>().Add(entity);

                    context.SaveChanges();
                }
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
                using (var context = new TContext())
                {
                    context.Remove(entity);
                    context.SaveChanges();
                }
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
                using (var context = new TContext())
                {
                    foreach (var entity in entities)
                        context.Remove(entity);

                    context.SaveChanges();
                }
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
                using (var context = new TContext())
                {
                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
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
                using (var context = new TContext())
                {
                    foreach (var entity in entities)
                        context.Entry(entity).State = EntityState.Modified;

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //TODO:Should be logging
                throw;
            }
        }
    }
}
