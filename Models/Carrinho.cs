
using System.ComponentModel.DataAnnotations;

namespace loja.Models
{
    public class Carrinho
    {
        [Display(Name = "Código")]
        public int Id {get; set;}
        [Display(Name = "Código Usuário")]
        public int UsuarioId {get; set;}

        public Usuario Usuario {get; set;} = null!;

        public List<Produto> Produtos {get; } = new();
    }
}