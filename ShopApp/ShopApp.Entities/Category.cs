using System.Collections.Generic;

namespace ShopApp.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
