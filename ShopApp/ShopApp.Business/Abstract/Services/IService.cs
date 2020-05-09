using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.Business.Abstract
{
    public interface IService<TEntity>
    {
        TEntity GetById(int id);
        TEntity GetByFilter(Expression<Func<TEntity, bool>> filter);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetListByFilter(Expression<Func<TEntity, bool>> filter);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
    }
}
