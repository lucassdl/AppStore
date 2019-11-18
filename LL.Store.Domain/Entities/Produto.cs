using System;

namespace LL.Store.Domain.Entities
{
    public class Produto : Entity
    {
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public Int16 Qtde { get; set; }

        public int TipoDeProdutoId { get; set; }

        public virtual TipoDeProduto TipoDeProduto { get; set; }
    }
}
