using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challenge.API.Domains.Entities
{
    [Table("Consulta")]
    public class ConsultaEntity
    {
        [Key]
        public string idConsulta { get; set; }
        public DateTime dateConsulta { get; set; }
        public string tipoConsulta { get; set; }
        public double valorMedioConsulta { get; set; }

        public DentistaEntity dentista { get; set; }
        public ClienteEntity cliente { get; set; }
    }
}
