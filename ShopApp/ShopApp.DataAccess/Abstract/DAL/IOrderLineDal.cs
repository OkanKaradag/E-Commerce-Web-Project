using ShopApp.DataAccess.Abstract.Repository;
using ShopApp.Entities;
namespace ShopApp.DataAccess.Abstract.DAL
{
    public interface IOrderLineDal : IRepository<OrderLine>
    {
        decimal GetTotalPriceOfUnit();
    }
}
