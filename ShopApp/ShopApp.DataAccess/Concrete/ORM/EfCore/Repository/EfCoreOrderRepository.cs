using ShopApp.DataAccess.Abstract.Repository;
using ShopApp.Entities;
using System;

namespace ShopApp.DataAccess.Concrete.ORM.EfCore.Repository
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
