﻿using LL.Store.Domain.Contracts.Repositories;
using LL.Store.UI.ViewModels.Produtos.AddEdit;
using LL.Store.UI.ViewModels.Produtos.AddEdit.Maps;
using LL.Store.UI.ViewModels.Produtos.Index.Maps;
using System.Web.Mvc;

namespace LL.Store.UI.Controllers
{
    [Authorize]
    public class ProdutosController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ITipoDeProdutoRepository _tipoDeProdutoRepository;

        public ProdutosController(IProdutoRepository produtoRepository, ITipoDeProdutoRepository tipoDeProdutoRepository)
        {
            _produtoRepository = produtoRepository;
            _tipoDeProdutoRepository = tipoDeProdutoRepository;
        }

        [HttpGet]
        public ViewResult Index()
        {
            var produtos = _produtoRepository.Get().ToProdutoIndexVM();

            return View(produtos);
        }

        [HttpGet]
        public ViewResult AddEdit(int? id)
        {
            var produto = new ProdutoAddEditVM();

            if (id != null)
                produto = _produtoRepository.Get((int)id).ToProdutoAddEditVM();

            var tipos = _tipoDeProdutoRepository.Get();
            ViewBag.Tipos = tipos;

            return View(produto);
        }

        [HttpPost]
        public ActionResult AddEdit(ProdutoAddEditVM produtoVM)
        {
            var produto = produtoVM.ToProduto();

            if (ModelState.IsValid)
            {
                if (produto.Id == 0)
                    _produtoRepository.Add(produto);
                else
                    _produtoRepository.Edit(produto);

                return RedirectToAction("Index");
            }

            var tipos = _tipoDeProdutoRepository.Get();
            ViewBag.Tipos = tipos;

            return View(produto);
        }

        public ActionResult DelProduto(int id)
        {
            var produto = _produtoRepository.Get(id);

            if (produto == null)
                return HttpNotFound();
            else
                _produtoRepository.Remove(produto);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
        }
    }
}
