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
        public required DateTime dateConsulta { get; set; }

        [Required(ErrorMessage = "O Campo Tipo da Consulta e Obrigatorio")]
        public required string tipoConsulta { get; set; }

        [Required(ErrorMessage = "O Campo Valor da Consulta e Obrigatorio")]
        public required double valorMedioConsulta { get; set; }

        [Required(ErrorMessage = "O Campo Dentista e Obrigatorio")]
        public required DentistaEntity dentista { get; set; }

        [Required(ErrorMessage = "O Campo Cliente e Obrigatorio")]
        public required ClienteEntity cliente { get; set; }
    }
}
