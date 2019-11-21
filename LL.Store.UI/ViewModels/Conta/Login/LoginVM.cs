using System.ComponentModel.DataAnnotations;

namespace LL.Store.UI.ViewModels.Conta.Login
{
    public class LoginVM
    {
        [Required(ErrorMessage = "O {0} é obrigatório.")]
        [StringLength(40, ErrorMessage = "O limite do {0} é de {1} caracteres.")]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$", ErrorMessage = "{0} inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A {0} é obrigatória.")]
        [StringLength(40, ErrorMessage = "O limite do {0} é de {1} caracteres.")]
        public string Senha { get; set; }
        public bool PermanecerLogado { get; set; }
        public string ReturnUrl { get; set; }
    }
}
