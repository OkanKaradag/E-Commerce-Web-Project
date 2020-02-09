using System.Collections.Generic;

namespace ShopApp.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
