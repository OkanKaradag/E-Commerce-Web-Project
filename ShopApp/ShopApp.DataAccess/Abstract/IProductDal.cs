using ShopApp.Entities;
using System.Collections.Generic;

namespace ShopApp.DataAccess.Abstract
{
    public interface IProductDal : IRepository<Product>
    {
        IEnumerable<Product> GetPopularProducts();
    }
}
