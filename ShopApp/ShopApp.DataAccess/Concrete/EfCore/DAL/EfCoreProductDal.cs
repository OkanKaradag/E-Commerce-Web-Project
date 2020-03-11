using ShopApp.DataAccess.Abstract;
using ShopApp.DataAccess.Concrete.EfCore.Repository;
using ShopApp.Entities;
using System.Collections.Generic;

namespace ShopApp.DataAccess.Concrete.EfCore.DAL
{
    public class EfCoreProductDal : EfCoreRepository<Product, ShopContext>
    {
        public IEnumerable<Product> GetPopularProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}
