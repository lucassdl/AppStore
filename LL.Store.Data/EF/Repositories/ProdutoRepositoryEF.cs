using System.Collections.Generic;
using System.Linq;
using LL.Store.Domain.Contracts.Repositories;
using LL.Store.Domain.Entities;

namespace LL.Store.Data.EF.Repositories
{
    public class ProdutoRepositoryEF : RepositoryEF<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> GetByNameContains(string contains)
        {
            return _ctx.Produtos.Where(p => p.Nome.Contains(contains));
        }
    }
}
