using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_8.DAL.Interfaces
{
    public interface IRepositoty<TEntity, Tkey> where TEntity : class
    {
        IQueryable<TEntity> Query();

        IEnumerable<TEntity> GetAnimalList(Func<TEntity, bool> predicate);

        TEntity GetAnimalById(Tkey id);

        IEnumerable<TEntity> GetAll();

        TEntity Add(TEntity item);

        IEnumerable<TEntity> AddRange(IEnumerable<TEntity> items);

        TEntity Delete(Tkey id);

        IEnumerable<TEntity> DeleteRange(IEnumerable<TEntity> items);
    }
}