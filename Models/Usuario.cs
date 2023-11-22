
using System.ComponentModel.DataAnnotations;

namespace loja.Models
{
    public class Usuario
    {

        [Display(Name = "Código")]
        public int Id {get; set;}
        public string Login {get; set;}
        [Display(Name = "Senha")]
        public string Password {get; set;}
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email {get; set;}
    }
}