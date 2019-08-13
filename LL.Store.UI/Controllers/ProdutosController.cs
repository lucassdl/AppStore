using LL.Store.UI.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LL.Store.UI.Controllers
{
    public class ProdutosController : Controller
    {
        public ViewResult Index()
        {
            var produtos = new List<Produto>()
            {
                new Produto(){Id=1,Nome="Picanha",Preco=70.5m,Qtde=150, Tipo="Alimento"},
                new Produto(){Id=2,Nome="Pasta de Dente",Preco=9.5m,Qtde=250, Tipo="Higiene"},
                new Produto(){Id=3,Nome="Desinfetante",Preco=8.99m,Qtde=520, Tipo="Limpeza"}
            };

            return View(produtos);
        }
    }
}
