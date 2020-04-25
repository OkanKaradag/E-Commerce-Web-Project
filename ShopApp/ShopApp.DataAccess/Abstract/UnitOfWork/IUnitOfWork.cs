using ShopApp.DataAccess.Abstract.Repository;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Abstract.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
