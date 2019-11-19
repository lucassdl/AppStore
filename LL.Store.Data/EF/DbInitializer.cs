using LL.Store.Domain.Entities;
using LL.Store.Domain.Helpers;
using System.Collections.Generic;
using System.Data.Entity;

namespace LL.Store.Data.EF
{
    internal class DbInitializer : CreateDatabaseIfNotExists<LLStoreDataContext>
    {
        protected override void Seed(LLStoreDataContext context)
        {
            var alimento = new TipoDeProduto() { Nome = "Alimento" };
            var higiene = new TipoDeProduto() { Nome = "Higiene" };
            var eletronico = new TipoDeProduto() { Nome = "Eletrônico" };
            var limpeza = new TipoDeProduto() { Nome = "Limpeza" };

            var produtos = new List<Produto>()
            {
                new Produto(){Nome="Picanha",Preco=70.5m,Qtde=150, TipoDeProduto = alimento },
                new Produto(){Nome="Iogurte",Preco=10.5m,Qtde=250, TipoDeProduto = alimento },
                new Produto(){Nome="Pasta de Dente",Preco=9.5m,Qtde=250, TipoDeProduto=higiene},
                new Produto(){Nome="Sabonete",Preco=5.5m,Qtde=1250, TipoDeProduto=higiene},
                new Produto(){Nome="Desinfetante",Preco=8.99m,Qtde=520, TipoDeProduto=limpeza},
                new Produto(){Nome="Detergente",Preco=4.50m,Qtde=1520, TipoDeProduto=limpeza},
                new Produto(){Nome="Telefone sem Fio",Preco=125.15m,Qtde=85, TipoDeProduto=eletronico}
            };

            context.Produtos.AddRange(produtos);

            context.Usuarios.Add(new Usuario()
            {
                Nome = "Lucas Lima",
                Email = "lucas_sdl@hotmail.com",
                Senha = "123456".Encrypt()
            });

            context.SaveChanges();
        }
    }
}