namespace Challenge.API.Domains.Entities
{
    public class DentistaEntity
    {
        private string cpf_cnpj;
        private string cepClinica;
        private string nomeClinica;
        private string tipoClinica;
        private bool alvaraFuncionamento;
        private string siteRedesSocial;

        private UsuarioEntity usuario;
        private List<ConsultaEntity> consultas;
    }
}
