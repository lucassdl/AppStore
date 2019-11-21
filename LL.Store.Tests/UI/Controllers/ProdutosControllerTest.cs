using LL.Store.Domain.Contracts.Repositories;
using LL.Store.Domain.Entities;
using LL.Store.UI.Controllers;
using LL.Store.UI.ViewModels.Produtos.Index;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace LL.Store.Tests.UI.Controllers
{
    [TestClass, TestCategory("Controllers/ProdutosController")]
    public class ProdutosControllerTest
    {
        /// <summary>
        /// O método deverá retornar a view com o modelo correto
        /// </summary>
        [TestMethod]
        public void TesteMetodoIndexProduto()
        {
            //arrange
            var produtosController = new ProdutosController(new ProdutoRepositoryFake(), new TipoDeProdutoRepositoryFake());

            //act
            var result = produtosController.Index();
            var model = result.Model as IEnumerable<ProdutoIndexVM>;

            //assert
            Assert.AreEqual(typeof(ViewResult), result.GetType());
            Assert.AreEqual(3, model.Count());
            Assert.IsNotNull(model);
        }
    }


    public class ProdutoRepositoryFake : IProdutoRepository
    {
        public ProdutoRepositoryFake()
        {
        }

        public void Add(Produto entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void Edit(Produto entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Produto> Get()
        {
            var tipo1 = new TipoDeProduto() { Id = 1, Nome = "Tipo 1" };
            var tipo2 = new TipoDeProduto() { Id = 2, Nome = "Tipo 2" };

            return new List<Produto>()
            {
                new Produto(){Id = 1, Nome = "Produto 1", Preco = 1, Qtde = 10, TipoDeProduto = tipo1},
                new Produto(){Id = 2, Nome = "Produto 2", Preco = 2, Qtde = 20, TipoDeProduto = tipo2},
                new Produto(){Id = 3, Nome = "Produto 3", Preco = 3, Qtde = 30, TipoDeProduto = tipo1}
            };
        }

        public Produto Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Produto> GetByNameContains(string contains)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Produto entity)
        {
            throw new System.NotImplementedException();
        }
    }

    public class TipoDeProdutoRepositoryFake : ITipoDeProdutoRepository
    {
        public TipoDeProdutoRepositoryFake()
        {
        }

        public void Add(TipoDeProduto entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void Edit(TipoDeProduto entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TipoDeProduto> Get()
        {
            throw new System.NotImplementedException();
        }

        public TipoDeProduto Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(TipoDeProduto entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
