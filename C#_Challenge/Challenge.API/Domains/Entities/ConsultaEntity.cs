using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challenge.API.Domains.Entities
{
    public class ConsultaEntity
    {
        private string idConsulta;
        private Date dateConsulta;
        private string tipoConsulta;
        private double valorMedioConsulta;

        private DentistaEntity dentista { get; set; }
        private ClienteEntity cliente { get; set; }
    }
}
