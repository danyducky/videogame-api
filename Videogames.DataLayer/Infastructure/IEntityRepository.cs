using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.DataLayer.Infastructure
{
    public interface IEntityRepository<in TEntityInterface> where TEntityInterface : class
    {
        DbSet<TEntity> GetTableInternal<TEntity>() where TEntity : class, TEntityInterface;
        IQueryable<TEntity> GetTable<TEntity>() where TEntity : class, TEntityInterface;
        void InsertOnSave<TEntity>(TEntity entity) where TEntity : class, TEntityInterface;
        void DeleteOnSave<TEntity>(TEntity entity) where TEntity : class, TEntityInterface;
        void SaveChanges();
    }
}
