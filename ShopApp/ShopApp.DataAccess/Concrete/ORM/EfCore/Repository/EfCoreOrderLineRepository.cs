using ShopApp.DataAccess.Abstract.Repository;
using ShopApp.Entities;

namespace ShopApp.DataAccess.Concrete.ORM.EfCore.Repository
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
