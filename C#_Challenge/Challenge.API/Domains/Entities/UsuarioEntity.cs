using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challenge.API.Domains.Entities
{
    [Table("Usuario")]
    public class UsuarioEntity
    {
        [Key]
        public string idUsuario { get; set; }
        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }

    }
}
