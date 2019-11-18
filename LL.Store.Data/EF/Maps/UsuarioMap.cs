using LL.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL.Store.Data.EF.Maps
{
    public class UsuarioMap:EntityTypeConfiguration<Usuario>
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
                 .IsRequired();

            Property(prod => prod.Senha)
                .HasColumnType("char")
                .HasMaxLength(88)
                .IsRequired();
        }
    }
}
