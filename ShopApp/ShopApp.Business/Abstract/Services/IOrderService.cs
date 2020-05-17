using ShopApp.Entities;

namespace ShopApp.Business.Abstract.Services
{
    public interface IOrderService : IService<Order>
    {
        Order GetMostExpensiveOrder();
    }
}
