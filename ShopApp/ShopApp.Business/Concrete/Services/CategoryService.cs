using ShopApp.Business.Abstract.Services;
using ShopApp.DataAccess.Abstract.Repository;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ShopApp.Business.Concrete.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Add(Category entity)
        {
            _categoryRepository.Add(entity);
        }

        public void AddRange(IEnumerable<Category> entities)
        {
            _categoryRepository.AddRange(entities);
        }

        public void Delete(Category entity)
        {
            _categoryRepository.Delete(entity);
        }

        public void DeleteRange(IEnumerable<Category> entities)
        {
            _categoryRepository.DeleteRange(entities);
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetByFilter(Expression<Func<Category, bool>> filter)
        {
            return _categoryRepository.GetByFilter(filter);
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public IEnumerable<Category> GetListByFilter(Expression<Func<Category, bool>> filter)
        {
            return _categoryRepository.GetListByFilter(filter);
        }

        public IEnumerable<Category> GetSubCategories(int categoryId)
        {
            return _categoryRepository.GetSubCategories(categoryId);
        }

        public void Update(Category entity)
        {
            _categoryRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<Category> entities)
        {
            _categoryRepository.UpdateRange(entities);
        }
    }
}
