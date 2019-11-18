using LL.Store.UI.Data;
using LL.Store.UI.Infra.Helpers;
using LL.Store.UI.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace LL.Store.UI.Controllers
{
    public class ContaController : Controller
    {
        private readonly LLStoreDataContext _ctx = new LLStoreDataContext();

        public ActionResult Login(string returnUrl)
        {
            var model = new LoginVM() { ReturnUrl = returnUrl };
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginVM model)
        {
            var usuario = _ctx.Usuarios.FirstOrDefault(u => u.Email.ToLower() == model.Email.ToLower());

            if (usuario == null)
            {
                ModelState.AddModelError("Email", "O email não foi localizado.");
            }
            else
            {
                if (usuario.Senha != model.Senha.Encrypt())
                {
                    ModelState.AddModelError("Senha", "Senha inválida.");
                }
            }

            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(model.Email, model.PermanecerLogado);

                if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                {
                    return Redirect(model.ReturnUrl);
                }

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }
    }
}
