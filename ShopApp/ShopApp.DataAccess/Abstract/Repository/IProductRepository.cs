﻿using ShopApp.DataAccess.Abstract.Repository;
using ShopApp.Entities;
using System.Collections.Generic;

namespace ShopApp.DataAccess.Abstract.DAL
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetPopularProducts();
    }
}