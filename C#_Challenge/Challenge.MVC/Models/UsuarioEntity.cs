using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.MVC.Models
{
    [Table("tb_Usuario")]
    public class UsuarioEntity
    {
        [Key]
        public string idUsuario { get; set; }

        [Required(ErrorMessage = "O Campo Nome e Obrigatorio")]
        [DisplayName("Nome")]
        [StringLength(100)]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "O Campo Data de Nascimento e Obrigatorio")]
        [DisplayName("Data de Nascimento")]
        public required DateTime dataNascimento { get; set; }

        [Required(ErrorMessage = "O Campo Email e Obrigatorio")]
        [DisplayName("Email")]
        [EmailAddress]
        public required string Email { get; set; }

        [Required(ErrorMessage = "O Campo Celular e Obrigatorio")]
        [DisplayName("Celular")]
        public required string Celular { get; set; }
    }
}
