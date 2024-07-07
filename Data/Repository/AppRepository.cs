using Microsoft.EntityFrameworkCore;
using Playmove.Data.Interfaces;
using System.Linq.Expressions;

namespace Playmove.Data.Repository
{

    public abstract class AppRepository<TEntity> : IAppRepository<TEntity> where TEntity : class, new()
    {
        protected AppDbContext Db;
        protected DbSet<TEntity> DbSet;

        protected AppRepository(AppDbContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public async Task<TEntity> FirstOrDefaultAsNoTracking(Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return DbSet.AsNoTracking().Where(predicate).FirstOrDefault();
            }

            return await DbSet.AsNoTracking().FirstOrDefaultAsync();
        }

        public virtual async Task<TEntity> FindByKey(params object[] keyValues)
        {
            return await DbSet.FindAsync(keyValues);
        }

        public virtual async Task<List<TEntity>> FindAllAsNoTracking()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }

        public virtual async Task Insert(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Delete(params object[] keyValues)
        {
            var entity = await FindByKey(keyValues);

            if (entity != null)
                DbSet.Remove(entity);

            await SaveChanges();
        }

        public async Task SaveChanges()
        {
            await Db.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
