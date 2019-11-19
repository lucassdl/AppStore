using LL.Store.Data.EF;
using LL.Store.Domain.Entities;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace LL.Store.UI.Controllers
{
    [Authorize]
    public class ProdutosController : Controller
    {
        private readonly LLStoreDataContext _ctx = new LLStoreDataContext();

        [HttpGet]
        public ViewResult Index()
        {
            var produtos = _ctx.Produtos.ToList();

            return View(produtos);
        }

        [HttpGet]
        public ViewResult AddEdit(int? id)
        {
            Produto produto = new Produto();

            if (id != null)
                produto = _ctx.Produtos.Find(id);

            var tipos = _ctx.TipoDeProdutos.ToList();
            ViewBag.Tipos = tipos;

            return View(produto);
        }

        [HttpPost]
        public ActionResult AddEdit(Produto produto)
        {
            if (ModelState.IsValid)
            {
                if (produto.Id == 0)
                    _ctx.Produtos.Add(produto);
                else
                    _ctx.Entry(produto).State = EntityState.Modified;

                _ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            var tipos = _ctx.TipoDeProdutos.ToList();
            ViewBag.Tipos = tipos;

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
