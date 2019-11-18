using LL.Store.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LL.Store.Data.EF.Maps
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable(nameof(Produto));

            HasKey(pk => pk.Id);

            Property(prod => prod.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(prod => prod.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(prod => prod.Preco)
                .HasColumnType("money");

            Property(prod => prod.Qtde)
                .HasColumnName("Quantidade");

            Property(prod => prod.TipoDeProdutoId);

            Property(prod => prod.DataCadastro);
            
            HasRequired(prod => prod.TipoDeProduto)
                .WithMany(tprod => tprod.Produtos)
                .HasForeignKey(fk => fk.TipoDeProdutoId);
        }
    }
}
