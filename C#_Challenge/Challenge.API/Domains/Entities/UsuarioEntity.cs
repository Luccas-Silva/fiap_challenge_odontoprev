using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challenge.API.Domains.Entities
{
    public class UsuarioEntity
    {
        private string idUsuario { get; set; }
        private string nome { get; set; }
        private Date dataNascimento { get; set; }
        private string Email { get; set; }
        private string Celular { get; set; }

    }
}
