using Challenge.API.Domains.Entities;
using Microsoft.EntityFrameworkCore;

namespace Challenge.API.Infrastructure.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
        }

        public DbSet<ClienteEntity> Cliente { get; set; }
        public DbSet<DentistaEntity> Dentista { get; set; }
        public DbSet<ConsultaEntity> Consulta { get; set; }
        public DbSet<UsuarioEntity> Usuari { get; set; }

    }
}
