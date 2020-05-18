using ShopApp.DataAccess.Abstract.Repository;
using ShopApp.DataAccess.Abstract.UnitOfWork;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.ORM.EfCore.Repository
{
    public class EfCoreUnitOfWork : IUnitOfWork       
    {
        private readonly ShopContext _dbContext;

        public EfCoreUnitOfWork(ShopContext dbContext)
        {
            _dbContext = dbContext;
        }

        #region UnitOfWork Members
        public IRepository<T> GetRepository<T>() where T : class
        {
            return new EfCoreRepository<T>(_dbContext);
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.SaveChangesAsync(cancellationToken);
        }
        #endregion

        #region IDisposable Members
        //Here we implement the Dispose Pattern of the IDisposable interface that we have implemented in the IUnitOfWork interface.
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }

            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
