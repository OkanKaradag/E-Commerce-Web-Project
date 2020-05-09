using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract.DAL;
using ShopApp.DataAccess.Concrete.EfCore.Repository;
using ShopApp.Entities;
using System.Collections.Generic;

namespace ShopApp.DataAccess.Concrete.EfCore.DAL
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
