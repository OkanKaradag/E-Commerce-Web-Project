using ShopApp.Business.Abstract.Services;
using ShopApp.DataAccess.Abstract.Repository;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ShopApp.Business.Concrete.Services
{
    public class OrderLineService : IOrderLineService
    {
        private readonly IOrderLineRepository _orderLineRepository;

        public OrderLineService(IOrderLineRepository orderLineRepository)
        {
            _orderLineRepository = orderLineRepository;
        }

        public void Add(OrderLine entity)
        {
            _orderLineRepository.Add(entity);
        }

        public void AddRange(IEnumerable<OrderLine> entities)
        {
            _orderLineRepository.AddRange(entities);
        }

        public void Delete(OrderLine entity)
        {
            _orderLineRepository.Delete(entity);
        }

        public void DeleteRange(IEnumerable<OrderLine> entities)
        {
            _orderLineRepository.DeleteRange(entities);
        }

        public IEnumerable<OrderLine> GetAll()
        {
            return _orderLineRepository.GetAll();
        }

        public OrderLine GetByFilter(Expression<Func<OrderLine, bool>> filter)
        {
            return _orderLineRepository.GetByFilter(filter);
        }

        public OrderLine GetById(int id)
        {
            return _orderLineRepository.GetById(id);
        }

        public IEnumerable<OrderLine> GetListByFilter(Expression<Func<OrderLine, bool>> filter)
        {
            return _orderLineRepository.GetListByFilter(filter);
        }

        public decimal GetTotalPriceOfUnit()
        {
            return _orderLineRepository.GetTotalPriceOfUnit();
        }

        public void Update(OrderLine entity)
        {
            _orderLineRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<OrderLine> entities)
        {
            _orderLineRepository.UpdateRange(entities);
        }
    }
}
