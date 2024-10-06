namespace Challenge.API.Domains.Entities
{
    public class ClienteEntity
    {
        private string cpf_cnpj { get; set; }
        private string cep { get; set; }
        private string tipoPlano { get; set; }

        private UsuarioEntity usuario { get; set; }
        private List<ConsultaEntity> consultas { get; set; } 

    }
}
