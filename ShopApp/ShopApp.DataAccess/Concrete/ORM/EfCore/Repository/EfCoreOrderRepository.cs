using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract.DAL;
using ShopApp.DataAccess.Concrete.EfCore.Repository;
using ShopApp.Entities;
using System;

namespace ShopApp.DataAccess.Concrete.ORM.EfCore.DAL
{
    public class EfCoreOrderRepository : EfCoreRepository<Order>, IOrderRepository
    {
        private readonly ShopContext _dbContext;

        public EfCoreOrderRepository(ShopContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Order GetMostExpensiveOrder()
        {
            //TODO:Write this method business
            throw new NotImplementedException();
        }
    }
}
