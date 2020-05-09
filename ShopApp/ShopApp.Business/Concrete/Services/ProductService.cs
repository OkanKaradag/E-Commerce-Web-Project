using ShopApp.DataAccess.Abstract.DAL;
using ShopApp.DataAccess.Concrete.EfCore.DAL;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ShopApp.Business.Abstract.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(Product entity)
        {
            _productRepository.Add(entity);
        }

        public void AddRange(IEnumerable<Product> entities)
        {
            _productRepository.AddRange(entities);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public void DeleteRange(IEnumerable<Product> entities)
        {
            _productRepository.DeleteRange(entities);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetByFilter(Expression<Func<Product, bool>> filter)
        {
            return _productRepository.GetByFilter(filter);
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public IEnumerable<Product> GetListByFilter(Expression<Func<Product, bool>> filter)
        {
            return _productRepository.GetListByFilter(filter);
        }

        public IEnumerable<Product> GetPopularProducts()
        {
            return _productRepository.GetPopularProducts();
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<Product> entities)
        {
            _productRepository.UpdateRange(entities);
        }
    }
}
