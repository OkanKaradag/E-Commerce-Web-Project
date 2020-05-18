using ShopApp.DataAccess.Abstract.Repository;
using ShopApp.Entities;
using System.Collections.Generic;

namespace ShopApp.DataAccess.Concrete.ORM.EfCore.Repository
{
    public class EfCoreCategoryRepository : EfCoreRepository<Category>, ICategoryRepository
    {
        private readonly ShopContext _dbContext;

        public EfCoreCategoryRepository(ShopContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Category> GetSubCategories(int categoryId)
        {
            //TODO:Write this method business
            throw new System.NotImplementedException();
        }
    }
}
