using LL.Store.UI.Data;
using System.Linq;
using System.Web.Mvc;
using LL.Store.UI.Models;
using System.Collections.Generic;

namespace LL.Store.UI.Controllers
{
    public class ProdutosController : Controller
    {
		[HttpGet]
        public ViewResult Index()
        {
            IList<Produto> produtos = null;

            using (var ctx = new LNStoreDataContext())
            {
                produtos = ctx.Produtos.ToList();
            }

            return View(produtos);
        }

		[HttpGet]
		public ViewResult Add()
        {
            return View();
        }

		[HttpPost]
		public ActionResult Add(Produto produto)
        {
            return RedirectToAction("Index");
        }
    }
}
