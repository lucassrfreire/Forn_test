using System.Linq.Expressions;

namespace Playmove.Data.Interfaces
{
    public interface IAppRepository<TEntity> : IDisposable where TEntity : class
    {
        Task Insert(TEntity entity);
        Task Delete(params object[] keyValues);
        Task<TEntity> FindByKey(params object[] keyValues);
        Task<List<TEntity>> FindAllAsNoTracking();
        Task<TEntity> FirstOrDefaultAsNoTracking(Expression<Func<TEntity, bool>> predicate = null);
        Task Update(TEntity entity);
        Task SaveChanges();
    }
}
