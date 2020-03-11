using ShopApp.DataAccess.Abstract.DAL;
using ShopApp.DataAccess.Concrete.EfCore.Repository;
using ShopApp.Entities;
using System.Collections.Generic;

namespace ShopApp.DataAccess.Concrete.EfCore.DAL
{
    public class EfCoreCategoryDal : EfCoreRepository<Category, ShopContext>, ICategoryDal
    {
        public IEnumerable<Category> GetSubCategories(int categoryId)
        {
            throw new System.NotImplementedException();
        }
    }
}
