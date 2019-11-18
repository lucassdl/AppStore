using LL.Store.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LL.Store.Data.EF.Maps
{
    public class TipoDeProdutoMap : EntityTypeConfiguration<TipoDeProduto>
    {
        public TipoDeProdutoMap()
        {
            ToTable(nameof(TipoDeProduto));

            HasKey(pk => pk.Id);

            Property(prod => prod.Id)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(prod => prod.Nome)
                    .HasColumnType("varchar")
                    .HasMaxLength(100)
                    .IsRequired();

            Property(prod => prod.DataCadastro);
        }
    }
}
