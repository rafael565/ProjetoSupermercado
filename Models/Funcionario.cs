using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoSupermercado.Models
{
    [Table("Funcionarios")]
    public class Funcionario
    {
        [Display(Name = "ID: ")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatório")]
        [StringLength(35)]
        [Display(Name = "Nome: ")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo CPF é obrigatório")]
        [StringLength(35)]
        [Display(Name = "Cpf: ")]
        public string cpf { get; set; }

        
        public Cargo cargo { get; set; }
        [Display(Name = "Cargo: ")]
        public int cargoID { get; set; }

      

    }
}
