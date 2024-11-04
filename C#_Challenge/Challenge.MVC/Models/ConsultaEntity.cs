using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.MVC.Models
{

    [Table("Consulta")]
    public class ConsultaEntity
    {
        [Key] 
        public string idConsulta { get; set; }

        [Required(ErrorMessage = "O Campo Data da Consulta e Obrigatorio")]
        [DisplayName("Data da Consulta")]
        public required DateTime dateConsulta { get; set; }

        [Required(ErrorMessage = "O Campo Tipo da Consulta e Obrigatorio")]
        [DisplayName("Tipo da Consulta")]
        [StringLength(100)]
        public required string tipoConsulta { get; set; }

        [Required(ErrorMessage = "O Campo Valor da Consulta e Obrigatorio")]
        [DisplayName("Valor da Consulta")]
        [Range(50, 2500)]
        public required double valorMedioConsulta { get; set; }

        [Required(ErrorMessage = "O Campo Dentista e Obrigatorio")]
        [DisplayName("Dentista")]
        public required DentistaEntity dentista { get; set; }

        [Required(ErrorMessage = "O Campo Cliente e Obrigatorio")]
        [DisplayName("Cliente")]
        public required ClienteEntity cliente { get; set; }
    }
}
