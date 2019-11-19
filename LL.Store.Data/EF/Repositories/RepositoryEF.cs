using LL.Store.Domain.Contracts.Repositories;
using LL.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LL.Store.Data.EF.Repositories
{
    public class RepositoryEF<T> : IDisposable, IRepository<T> where T : Entity
    {
        protected LLStoreDataContext _ctx = new LLStoreDataContext();

        public IEnumerable<T> Get()
        {
            return _ctx.Set<T>().ToList();
        }

        public T Get(int id)
        {
            return _ctx.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            _ctx.Set<T>().Add(entity);
            Save();
        }

        public void Edit(T entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
            Save();
        }

        public void Remove(T entity)
        {
            _ctx.Set<T>().Remove(entity);
            Save();
        }

        private void Save()
        {
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }

        
    }
}
