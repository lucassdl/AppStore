using LL.Store.Domain.Entities;
using System.Collections.Generic;

namespace LL.Store.Domain.Contracts.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        IEnumerable<Produto> GetByNameContains(string contains);
    }
}
