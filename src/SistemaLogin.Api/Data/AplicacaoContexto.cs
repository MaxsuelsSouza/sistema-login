using SistemaLogin.Api.Data.MapeamentoDominio;
using SistemaLogin.Api.Dominio.Usuarios;
using Microsoft.EntityFrameworkCore;

namespace SistemaLogin.Api.Data
{
    public class AplicacaoContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public AplicacaoContexto(DbContextOptions<AplicacaoContexto> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioContexto());
        }
    }
}