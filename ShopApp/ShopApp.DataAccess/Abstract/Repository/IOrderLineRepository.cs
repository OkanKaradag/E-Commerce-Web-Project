using ShopApp.DataAccess.Abstract.Repository;
using ShopApp.Entities;
namespace ShopApp.DataAccess.Abstract.DAL
{
    public interface IOrderLineRepository : IRepository<OrderLine>
    {
        decimal GetTotalPriceOfUnit();
    }
}
