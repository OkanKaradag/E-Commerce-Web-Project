using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract.DAL;
using ShopApp.DataAccess.Concrete.EfCore.Repository;
using ShopApp.Entities;
using System.Collections.Generic;

namespace ShopApp.DataAccess.Concrete.EfCore.DAL
{
    public class EfCoreProductRepository : EfCoreRepository<Product>, IProductRepository
    {
        private readonly DbContext _dbContext;

        public EfCoreProductRepository(ShopContext shopContext) : base(shopContext)
        {
            _dbContext = shopContext;
        }

        public IEnumerable<Product> GetPopularProducts()
        {
            //TODO:Write this method business
            throw new System.NotImplementedException();
        }
    }
}
