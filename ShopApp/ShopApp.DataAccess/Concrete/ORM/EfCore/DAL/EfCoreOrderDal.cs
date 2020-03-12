using ShopApp.DataAccess.Abstract.DAL;
using ShopApp.DataAccess.Concrete.EfCore.Repository;
using ShopApp.Entities;
using System;

namespace ShopApp.DataAccess.Concrete.ORM.EfCore.DAL
{
    public class EfCoreOrderDal : EfCoreRepository<Order, ShopContext>, IOrderDal
    {
        public Order GetMostExpensiveOrder()
        {
            throw new NotImplementedException();
        }
    }
}
