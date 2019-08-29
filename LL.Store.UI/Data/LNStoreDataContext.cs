using System.Data.Entity;
using LL.Store.UI.Models;

namespace LL.Store.UI.Data
{
    public class LNStoreDataContext : DbContext
    {
        public LNStoreDataContext() : base("StoreConn")
        {
            Database.SetInitializer(new DbInitializer());
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<TipoDeProduto> TipoDeProdutos { get; set; }
    }
}
