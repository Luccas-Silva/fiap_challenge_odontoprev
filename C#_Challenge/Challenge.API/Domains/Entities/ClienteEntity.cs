namespace Challenge.API.Domains.Entities
{
    public class ClienteEntity
    {
        private String cpf_cnpj { get; set; }
        private String cep { get; set; }
        private String tipoPlano { get; set; }

        private UsuarioEntity usuario { get; set; }
        private List<ConsultaEntity> consultas { get; set; } 

    }
}
