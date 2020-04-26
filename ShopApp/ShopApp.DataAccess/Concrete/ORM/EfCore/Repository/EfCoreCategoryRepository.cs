using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract.DAL;
using ShopApp.DataAccess.Concrete.EfCore.Repository;
using ShopApp.Entities;
using System.Collections.Generic;

namespace ShopApp.DataAccess.Concrete.EfCore.DAL
{
    public class EfCoreCategoryRepository : EfCoreRepository<Category>, ICategoryRepository
    {
        private readonly DbContext _dbContext;

        public EfCoreCategoryRepository(ShopContext shopContext) : base(shopContext)
        {
            _dbContext = shopContext;
        }

        public IEnumerable<Category> GetSubCategories(int categoryId)
        {
            //TODO:Write this method business
            throw new System.NotImplementedException();
        }
    }
}
