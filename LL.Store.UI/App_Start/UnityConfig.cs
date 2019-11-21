using LL.Store.Data.EF.Repositories;
using LL.Store.Domain.Contracts.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace LL.Store.UI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            container.RegisterType<IProdutoRepository, ProdutoRepositoryEF>();
            container.RegisterType<ITipoDeProdutoRepository, TipoDeProdutoRepositoryEF>();
            container.RegisterType<IUsuarioRepository, UsuarioRepositoryEF>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}