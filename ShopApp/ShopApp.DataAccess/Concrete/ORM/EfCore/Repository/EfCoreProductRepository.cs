﻿using ShopApp.DataAccess.Abstract.Repository;
using ShopApp.DataAccess.Concrete.EfCore.Repository;
using ShopApp.Entities;
using System.Collections.Generic;

namespace ShopApp.DataAccess.Concrete.EfCore.DAL
{
    public class EfCoreProductRepository : EfCoreRepository<Product>, IProductRepository
    {
        private readonly ShopContext _dbContext;

        public EfCoreProductRepository(ShopContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Product> GetPopularProducts()
        {
            //TODO:Write this method business
            throw new System.NotImplementedException();
        }
    }
}
