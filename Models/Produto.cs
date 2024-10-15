using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoSupermercado.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Display(Name = "ID: ")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatório")]
        [StringLength(35)]
        [Display(Name = "Nome: ")]
        public string nome { get; set; }

        [Display(Name = "Data de Validade: ")]
        public DateTime validade { get; set; }

        [Required(ErrorMessage = "Campo quantidade é obrigatório")]
        [Display(Name = "quantidade: ")]
        public int quantidade { get; set; }
    }
}
