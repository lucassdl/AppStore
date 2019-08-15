using LL.Store.UI.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace LL.Store.UI.Data
{
    internal class DbInitializer : CreateDatabaseIfNotExists<LNStoreDataContext>
    {
        protected override void Seed(LNStoreDataContext context)
        {
            var produtos = new List<Produto>()
            {
                new Produto(){Nome="Picanha",Preco=70.5m,Qtde=150, Tipo="Alimento"},
                new Produto(){Nome="Pasta de Dente",Preco=9.5m,Qtde=250, Tipo="Higiene"},
                new Produto(){Nome="Desinfetante",Preco=8.99m,Qtde=520, Tipo="Limpeza"},
                new Produto(){Nome="Telefone sem Fio",Preco=125.15m,Qtde=85, Tipo="Eletrônico"}
            };

            context.Produtos.AddRange(produtos);
            context.SaveChanges();
        }
    }
}