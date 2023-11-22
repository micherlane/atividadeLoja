using System.ComponentModel.DataAnnotations;

namespace loja.Models
{
    public class Produto
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao {get; set;}
        [Display(Name = "Caminho Image")]
        public string PathImage {get; set;}
        [Display(Name = "Preço")]
        public decimal Preco { get; set;}
        [Display(Name = "Quantidade")]
        public int Quantidate {get; set;}
        [Display(Name = "Código Categoria")]
        public int CategoriaId{get; set;}
        public Categoria Categoria{get; set;} = null!;

        public List<Carrinho> Carrinhos {get;} = new();


    }
}