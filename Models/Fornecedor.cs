using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoSupermercado.Models
{
    [Table("Fornecedores")]
    public class Fornecedor
    {
        [Display(Name = "ID: ")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatório")]
        [StringLength(35)]
        [Display(Name = "Nome: ")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo CNPJ é obrigatório")]
        [StringLength(35)]
        [Display(Name = "Cnpj: ")]
        public string cnpj { get; set; }

        public Produto produto { get; set; }
        [Display(Name = "Produto: ")]
        public int produtoID { get; set; }

        public int quantidade { get; set; }

        [Display(Name = "Data de entrega: ")]
        public DateTime validade { get; set; }


    }
}
