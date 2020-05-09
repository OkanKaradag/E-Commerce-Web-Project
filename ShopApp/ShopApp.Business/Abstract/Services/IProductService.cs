using ShopApp.Entities;
using System.Collections.Generic;

namespace ShopApp.Business.Abstract.Services
{
    public interface IProductService : IService<Product>
    {
        IEnumerable<Product> GetPopularProducts();
    }
}
