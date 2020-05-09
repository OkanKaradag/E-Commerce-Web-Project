using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract.DAL;
using ShopApp.DataAccess.Concrete.EfCore.Repository;
using ShopApp.Entities;

namespace ShopApp.DataAccess.Concrete.ORM.EfCore.DAL
{
    public class EfCoreOrderLineRepository : EfCoreRepository<OrderLine>, IOrderLineRepository
    {
        private readonly ShopContext _dbContext;

        public EfCoreOrderLineRepository(ShopContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public decimal GetTotalPriceOfUnit()
        {
            //TODO:Write this method business
            throw new System.NotImplementedException();
        }
    }
}
