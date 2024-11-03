using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.MVC.Models
{
    [Table("Dentista")]
    public class DentistaEntity
    {
        [Key]
        [Required(ErrorMessage = "O Campo CPF/CNPJ e Obrigatorio")]
        public required string cpf_cnpj { get; set; }

        [Required(ErrorMessage = "O Campo CEP da Clinica e Obrigatorio")]
        public required string cepClinica { get; set; }

        [Required(ErrorMessage = "O Campo Nome da Clinica e Obrigatorio")]
        public required string nomeClinica { get; set; }

        [Required(ErrorMessage = "O Campo Tipo da Clinica e Obrigatorio")]
        public required string tipoClinica { get; set; }

        [Required(ErrorMessage = "O Campo Alvara de Funcionamento e Obrigatorio")]
        public required bool alvaraFuncionamento { get; set; }

        public string siteRedesSocial { get; set; }

        [Required(ErrorMessage = "O Campo Usuario e Obrigatorio")]
        public required UsuarioEntity usuario { get; set; }

        public List<ConsultaEntity> consultas { get; set; }
    }
}
