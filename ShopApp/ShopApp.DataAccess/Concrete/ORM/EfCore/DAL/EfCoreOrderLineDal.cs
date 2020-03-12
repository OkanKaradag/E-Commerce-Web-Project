using ShopApp.DataAccess.Abstract.DAL;
using ShopApp.DataAccess.Concrete.EfCore.Repository;
using ShopApp.Entities;

namespace ShopApp.DataAccess.Concrete.ORM.EfCore.DAL
{
    public class EfCoreOrderLineDal : EfCoreRepository<OrderLine, ShopContext>, IOrderLineDal
    {
        public decimal GetTotalPriceOfUnit()
        {
            throw new System.NotImplementedException();
        }
    }
}
