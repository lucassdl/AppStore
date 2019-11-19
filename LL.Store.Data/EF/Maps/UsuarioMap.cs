using LL.Store.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace LL.Store.Data.EF.Maps
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable(nameof(Usuario));

            HasKey(pk => pk.Id);

            Property(prod => prod.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(prod => prod.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(prod => prod.Email)
                 .HasColumnType("varchar")
                 .HasMaxLength(80)
                 .IsRequired()
                 .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute( "UQ_dbo.Usuario.Email") { IsUnique = true })
                 );

            Property(prod => prod.Senha)
                .HasColumnType("char")
                .HasMaxLength(88)
                .IsRequired();
        }
    }
}
