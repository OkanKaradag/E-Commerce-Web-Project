using ShopApp.DataAccess.Abstract.Repository;
using ShopApp.Entities;

namespace ShopApp.DataAccess.Abstract.DAL
{
    public interface IOrderDal : IRepository<Order>
    {
        Order GetMostExpensiveOrder();
    }
}
