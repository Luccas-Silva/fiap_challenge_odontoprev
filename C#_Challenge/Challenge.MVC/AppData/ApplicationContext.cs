using Challenge.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Challenge.MVC.AppData
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options){}

        public DbSet<UsuarioEntity> Usuario { get; set; }
        public DbSet<ClienteEntity> Cliente { get; set; }
        public DbSet<DentistaEntity> Dentista { get; set; }
        public DbSet<ConsultaEntity> Consulta { get; set; }
    }
}
