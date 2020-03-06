using ShopApp.Entities;
namespace ShopApp.DataAccess.Abstract
{
    public interface IOrderLineDal : IRepository<OrderLine>
    {
        decimal GetTotalPriceOfUnit();
    }
}
