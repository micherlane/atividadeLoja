
using System.ComponentModel.DataAnnotations;

namespace loja.Models
{
    public class Categoria
    {
        [Display(Name = "Código")]
        public int Id {get; set;}
        public string Nome {get; set;}
    }
}