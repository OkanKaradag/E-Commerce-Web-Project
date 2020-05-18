using ShopApp.Business.Abstract.Services;
using ShopApp.DataAccess.Abstract.Repository;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ShopApp.Business.Concrete.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Add(Order entity)
        {
            _orderRepository.Add(entity);
        }

        public void AddRange(IEnumerable<Order> entities)
        {
            _orderRepository.AddRange(entities);
        }

        public void Delete(Order entity)
        {
            _orderRepository.Delete(entity);
        }

        public void DeleteRange(IEnumerable<Order> entities)
        {
            _orderRepository.DeleteRange(entities);
        }

        public IEnumerable<Order> GetAll()
        {
           return _orderRepository.GetAll();
        }

        public Order GetByFilter(Expression<Func<Order, bool>> filter)
        {
            return _orderRepository.GetByFilter(filter);
        }

        public Order GetById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public IEnumerable<Order> GetListByFilter(Expression<Func<Order, bool>> filter)
        {
            return _orderRepository.GetListByFilter(filter);
        }

        public Order GetMostExpensiveOrder()
        {
            return _orderRepository.GetMostExpensiveOrder();
        }

        public void Update(Order entity)
        {
            _orderRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<Order> entities)
        {
            _orderRepository.UpdateRange(entities);
        }
    }
}
