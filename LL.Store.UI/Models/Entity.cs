using System;
using System.ComponentModel.DataAnnotations;

namespace LL.Store.UI.Models
{
    public class Entity
    {
        public Entity()
        {
            DataCadastro = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
