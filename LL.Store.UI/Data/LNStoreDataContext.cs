using System.Data.Entity;
using LL.Store.UI.Models;

namespace LL.Store.UI.Data
{
    public class LNStoreDataContext : DbContext
    {
        public LNStoreDataContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=lnstore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Database.SetInitializer(new DbInitializer());
        }
        public DbSet<Produto> Produtos { get; set; }
    }
}
