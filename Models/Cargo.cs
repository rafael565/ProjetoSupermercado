using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoSupermercado.Models
{
    [Table("Cargos")]
    public class Cargo
    {
        [Display(Name = "ID: ")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatório")]
        [StringLength(35)]
        [Display(Name = "Nome: ")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo descrição é obrigatório")]
        [StringLength(35)]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Campo salario é obrigatório")]
        [Display(Name = "Salario: ")]
        public float salario { get; set; }

        [Required(ErrorMessage = "Campo quantidade funcionario é obrigatório")]
        [Display(Name = "quantidade funcionario : ")]
        public int quantidade { get; set; }

    }
}
