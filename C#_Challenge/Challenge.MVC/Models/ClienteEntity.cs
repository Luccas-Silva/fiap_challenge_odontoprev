using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.MVC.Models
{
    [Table("tb_Cliente")]
    public class ClienteEntity
    {
        [Key]
        [Required(ErrorMessage = "O Campo CPF/CNPJ e Obrigatorio")]
        [DisplayName("CPF/CNPJ")]
        public required string cpf_cnpj { get; set; }

        [Required(ErrorMessage = "O Campo CEP e Obrigatorio")]
        [DisplayName("CEP")]
        public required string cep { get; set; }

        [Required(ErrorMessage = "O Campo Tipo do Plano e Obrigatorio")]
        [DisplayName("Tipo do Plano")]
        [StringLength(50)]
        public required string tipoPlano { get; set; }

        [Required(ErrorMessage = "O Campo Usuario e Obrigatorio")]
        [DisplayName("Usuario")]
        public required UsuarioEntity usuario { get; set; }

        [DisplayName("Consultas")]
        public List<ConsultaEntity> consultas { get; set; }
    }
}
