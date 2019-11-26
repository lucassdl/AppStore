using LL.Store.Data.EF;
using LL.Store.Data.EF.Repositories;
using LL.Store.Domain.Contracts.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using LL.Store.Data.ADO.Repositories;

namespace LL.Store.UI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<LLStoreDataContextEF>();
            container.RegisterType<IProdutoRepository, ProdutoRepositoryEF>();
            container.RegisterType<ITipoDeProdutoRepository, TipoDeProdutoRepositoryEF>();
            container.RegisterType<IUsuarioRepository, UsuarioRepositoriesADO>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}