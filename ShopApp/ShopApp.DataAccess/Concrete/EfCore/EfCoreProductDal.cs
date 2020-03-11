using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System.Collections.Generic;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public class EfCoreProductDal : EfCoreRepository<Product, ShopContext>, IProductDal
    {
        public IEnumerable<Product> GetPopularProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}
