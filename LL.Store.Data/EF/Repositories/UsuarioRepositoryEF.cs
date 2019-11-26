using LL.Store.Domain.Contracts.Repositories;
using LL.Store.Domain.Entities;
using System.Linq;

namespace LL.Store.Data.EF.Repositories
{
    public class UsuarioRepositoryEF : RepositoryEF<Usuario>, IUsuarioRepository
    {
        public UsuarioRepositoryEF(LLStoreDataContextEF ctx) : base(ctx)
        {
        }

        public Usuario Get(string email)
        {
            return _ctx.Usuarios.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
        }
    }
}
