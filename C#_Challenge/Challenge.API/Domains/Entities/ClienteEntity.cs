using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.API.Domains.Entities
{
    [Table("Cliente")]
    public class ClienteEntity
    {
        [Key]
        public string cpf_cnpj { get; set; }
        public string cep { get; set; }
        public string tipoPlano { get; set; }

        public UsuarioEntity usuario { get; set; }
        public List<ConsultaEntity> consultas { get; set; } 

    }
}
