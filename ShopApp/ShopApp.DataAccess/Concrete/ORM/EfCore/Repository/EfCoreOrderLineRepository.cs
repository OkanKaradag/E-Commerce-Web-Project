using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract.DAL;
using ShopApp.DataAccess.Concrete.EfCore.Repository;
using ShopApp.Entities;

namespace ShopApp.DataAccess.Concrete.ORM.EfCore.DAL
{
    public class EfCoreOrderLineRepository : EfCoreRepository<OrderLine>, IOrderLineRepository
    {
        private readonly DbContext _dbContext;

        public EfCoreOrderLineRepository(ShopContext shopContext) : base(shopContext)
        {
            _dbContext = shopContext;
        }

        public decimal GetTotalPriceOfUnit()
        {
            //TODO:Write this method business
            throw new System.NotImplementedException();
        }
    }
}
