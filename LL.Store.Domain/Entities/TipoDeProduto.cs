using System.Collections.Generic;

namespace LL.Store.Domain.Entities
{
    public class TipoDeProduto:Entity
    {
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
