using ShopApp.DataAccess.Abstract.Repository;
using ShopApp.Entities;
using System.Collections.Generic;

namespace ShopApp.DataAccess.Abstract.DAL
{
    public interface ICategoryDal : IRepository<Category>
    {
        IEnumerable<Category> GetSubCategories(int categoryId);
    }
}
