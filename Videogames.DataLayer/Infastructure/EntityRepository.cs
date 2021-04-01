using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.DataLayer.Infastructure
{
    public class EntityRepository<TEntityInterface> : IEntityRepository<TEntityInterface> where TEntityInterface : class
    {
        private readonly VideogameDbContext db;
        public EntityRepository(VideogameDbContext db)
        {
            this.db = db;
        }

        public DbSet<TEntity> GetTableInternal<TEntity>() where TEntity : class, TEntityInterface
        {
            var tableInternal = db.Set<TEntity>();
            return tableInternal;
        }

        void IEntityRepository<TEntityInterface>.DeleteOnSave<TEntity>(TEntity entity)
        {
            GetTableInternal<TEntity>().Remove(entity);
        }

        void IEntityRepository<TEntityInterface>.InsertOnSave<TEntity>(TEntity entity)
        {
            GetTableInternal<TEntity>().Add(entity);
        }

        IQueryable<TEntity> IEntityRepository<TEntityInterface>.GetTable<TEntity>()
        {
            return GetTableInternal<TEntity>();
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }

    }
}
