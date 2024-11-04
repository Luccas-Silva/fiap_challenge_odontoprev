using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.MVC.Models
{
    [Table("tb_Dentista")]
    public class DentistaEntity
    {
        [Key]
        [Required(ErrorMessage = "O Campo CPF/CNPJ e Obrigatorio")]
        [DisplayName("CPF/CNPJ")]
        public required string cpf_cnpj { get; set; }

        [Required(ErrorMessage = "O Campo CEP da Clinica e Obrigatorio")]
        [DisplayName("CEP")]
        public required string cepClinica { get; set; }

        [Required(ErrorMessage = "O Campo Nome da Clinica e Obrigatorio")]
        [DisplayName("Nome da Clinica")]
        [StringLength(100)]
        public required string nomeClinica { get; set; }

        [Required(ErrorMessage = "O Campo Tipo da Clinica e Obrigatorio")]
        [DisplayName("Tipo da Clinica")]
        [StringLength(50)]
        public required string tipoClinica { get; set; }

        [Required(ErrorMessage = "O Campo Alvara de Funcionamento e Obrigatorio")]
        [DisplayName("Alvara de Funcionamento")]
        public required bool alvaraFuncionamento { get; set; }

        [DisplayName("Site - Redes Socia")]
        [StringLength(100)]
        public string siteRedesSocial { get; set; }

        [Required(ErrorMessage = "O Campo Usuario e Obrigatorio")]
        [DisplayName("Usuario")]
        public required UsuarioEntity usuario { get; set; }

        [DisplayName("Consultas")]
        public List<ConsultaEntity> consultas { get; set; }
    }
}
