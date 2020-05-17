using ShopApp.Entities;
using System.Collections.Generic;

namespace ShopApp.Business.Abstract.Services
{
    public interface ICategoryService : IService<Category>
    {
        IEnumerable<Category> GetSubCategories(int categoryId);
    }
}
