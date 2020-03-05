using ShopApp.Entities;

namespace ShopApp.DataAccess.Abstract
{
    public interface IOrderDal : IRepository<Order>
    {
        Order GetMostExpensiveOrder();
    }
}
