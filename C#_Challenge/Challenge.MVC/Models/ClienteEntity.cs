using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.MVC.Models
{
    [Table("Cliente")]
    public class ClienteEntity
    {
        [Key]
        [Required(ErrorMessage = "O Campo CPF/CNPJ e Obrigatorio")]
        public required string cpf_cnpj { get; set; }

        [Required(ErrorMessage = "O Campo CEP e Obrigatorio")]
        public required string cep { get; set; }

        [Required(ErrorMessage = "O Campo Tipo do Plano e Obrigatorio")]
        public required string tipoPlano { get; set; }

        [Required(ErrorMessage = "O Campo Usuario e Obrigatorio")]
        public required UsuarioEntity usuario { get; set; }

        public List<ConsultaEntity> consultas { get; set; }
    }
}
