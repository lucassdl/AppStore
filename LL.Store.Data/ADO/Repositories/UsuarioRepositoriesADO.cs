using LL.Store.Domain.Contracts.Repositories;
using LL.Store.Domain.Entities;
using System;
using System.Collections.Generic;

namespace LL.Store.Data.ADO.Repositories
{
    public class UsuarioRepositoriesADO : IUsuarioRepository
    {
        private readonly LLStoreDataContextADO _ctx;

        public UsuarioRepositoriesADO(LLStoreDataContextADO ctx)
        {
            _ctx = ctx;
        }


        public Usuario Get(string email)
        {
            var query = $@"SELECT u.Nome, u.Email, u.Senha, u.DataCadastro FROM Usuario u WHERE u.Email = '{email}'";

            var dr = _ctx.ExecuteDataReder(query);

            Usuario usuario = null;

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    usuario = new Usuario()
                    {
                        Nome = dr["Nome"].ToString(),
                        Email = dr["Email"].ToString(),
                        Senha = dr["Senha"].ToString(),
                        DataCadastro = Convert.ToDateTime(dr["DataCadastro"])
                    };
                };
            }

            dr.Close();

            return usuario;
        }

        public IEnumerable<Usuario> Get()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }

        public void Add(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Usuario Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
