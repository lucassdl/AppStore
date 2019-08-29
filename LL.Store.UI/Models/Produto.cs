using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LL.Store.UI.Models
{
    [Table(nameof(Produto))]
    public class Produto : Entity
    {
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Column(TypeName = "money")]
        public decimal Preco { get; set; }

        [Column("Quantidade")]
        public Int16 Qtde { get; set; }

        public int TipoDeProdutoId { get; set; }

        [ForeignKey(nameof(TipoDeProdutoId))]
        public virtual TipoDeProduto TipoDeProduto { get; set; }
    }
}
