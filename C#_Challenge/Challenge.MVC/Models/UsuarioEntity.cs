using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.MVC.Models
{
    [Table("Usuario")]
    public class UsuarioEntity
    {
        [Key]
        public string idUsuario { get; set; }

        [Required(ErrorMessage = "O Campo Nome e Obrigatorio")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "O Campo Data de Nascimento e Obrigatorio")]
        public required DateTime dataNascimento { get; set; }

        [Required(ErrorMessage = "O Campo Email e Obrigatorio")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "O Campo Celular e Obrigatorio")]
        public required string Celular { get; set; }
    }
}
