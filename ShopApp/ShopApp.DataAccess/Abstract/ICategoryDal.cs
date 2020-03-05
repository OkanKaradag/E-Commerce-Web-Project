using ShopApp.Entities;
using System.Collections.Generic;

namespace ShopApp.DataAccess.Abstract
{
    public interface ICategoryDal : IRepository<Category>
    {
        IEnumerable<Category> GetSubCategories(int categoryId);
    }
}
