using LL.Store.Domain.Entities;
using System.Collections.Generic;

namespace LL.Store.Domain.Contracts.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        void Add(T entity);
        void Edit(T entity);
        IEnumerable<T> Get();
        T Get(int id);
        void Remove(T entity);
    }
}