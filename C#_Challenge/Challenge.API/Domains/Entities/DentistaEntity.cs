using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.API.Domains.Entities
{
    [Table("Dentista")]
    public class DentistaEntity
    {
        [Key]
        public string cpf_cnpj { get; set; }
        public string cepClinica { get; set; }
        public string nomeClinica { get; set; }
        public string tipoClinica { get; set; }
        public bool alvaraFuncionamento { get; set; }
        public string siteRedesSocial { get; set; }

        public UsuarioEntity usuario { get; set; }
        public List<ConsultaEntity> consultas { get; set; }
    }
}
