using LL.Store.UI.Data;
using LL.Store.UI.Models;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

namespace LL.Store.UI.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly LNStoreDataContext _ctx = new LNStoreDataContext();

        [HttpGet]
        public ViewResult Index()
        {
            var produtos = _ctx.Produtos.ToList();

            return View(produtos);
        }

        [HttpGet]
        public ViewResult AddEdit(int? id)
        {
            Produto produto = null;

            if (id != null)
                produto = _ctx.Produtos.Find(id);

            return View(produto);
        }

        [HttpPost]
        public ActionResult AddEdit(Produto produto)
        {
            //TODO: Validar

            if (produto.Id == 0)
                _ctx.Produtos.Add(produto);
            else
                _ctx.Entry(produto).State = EntityState.Modified;

            _ctx.SaveChanges();

            return RedirectToAction("Index");
        }

        public ViewResult Edit(int id)
        {
            var produto = _ctx.Produtos.Find(id);
            return View(produto);
        }

        public ActionResult DelProduto(int id)
        {
            var produto = _ctx.Produtos.Find(id);

            if (produto == null)
            {
                return HttpNotFound();
            }
            else
            {
                _ctx.Produtos.Remove(produto);
                _ctx.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }


    }
}
