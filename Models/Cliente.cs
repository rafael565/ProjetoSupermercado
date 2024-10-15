using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoSupermercado.Models
{
    [Table("Clientes")]
    public class Cliente
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

        [Required(ErrorMessage = "Campo telefone é obrigatório")]
        [StringLength(35)]
        [Display(Name = "Telefone: ")]
        public string telefone { get; set; }

    }
}
