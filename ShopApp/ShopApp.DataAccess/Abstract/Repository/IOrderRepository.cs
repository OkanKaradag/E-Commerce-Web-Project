using ShopApp.DataAccess.Abstract.Repository;
using ShopApp.Entities;

namespace ShopApp.DataAccess.Abstract.DAL
{
    public interface IOrderRepository : IRepository<Order>
    {
        Order GetMostExpensiveOrder();
    }
}
