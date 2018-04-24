using Lab_8.DAL.EF;
using Lab_8.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Lab_8.DAL.Repositories
{
    public class Repository<TEntity, TKey> : IRepositoty<TEntity, TKey> where TEntity : class
    {
        protected readonly DBContext _context;

        protected readonly DbSet<TEntity> _dbSet; 

        public Repository(DBContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public IQueryable<TEntity> Query()
        {
            return _dbSet;
        }

        public IEnumerable<TEntity> GetAnimalList(Func<TEntity, bool> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public TEntity GetAnimalById(TKey id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public TEntity Add(TEntity item)
        {
            TEntity entity = _dbSet.Add(item);
            SaveChanges();
            return entity;
        }

        public IEnumerable<TEntity> AddRange(IEnumerable<TEntity> items)
        {
            IEnumerable<TEntity> entities = _dbSet.AddRange(items);
            SaveChanges();
            return entities;
        }

        public TEntity Delete(TKey id)
        {
            TEntity entity = _dbSet.Remove(_dbSet.Find(id));
            SaveChanges();
            return entity;
        }

        public IEnumerable<TEntity> DeleteRange(IEnumerable<TEntity> items)
        {
            IEnumerable<TEntity> entities = _dbSet.RemoveRange(items);
            SaveChanges();
            return entities;
        }
    }
}