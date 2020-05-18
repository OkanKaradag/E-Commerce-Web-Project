using ShopApp.Entities;

namespace ShopApp.DataAccess.Abstract.Repository
{
    public interface IOrderRepository : IRepository<Order>
    {
        Order GetMostExpensiveOrder();
    }
}
