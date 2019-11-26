using LL.Store.Domain.Contracts.Repositories;
using LL.Store.Domain.Entities;

namespace LL.Store.Data.EF.Repositories
{
    public class TipoDeProdutoRepositoryEF : RepositoryEF<TipoDeProduto>, ITipoDeProdutoRepository
    {
        public TipoDeProdutoRepositoryEF(LLStoreDataContextEF ctx) : base(ctx)
        {
        }
    }
}
