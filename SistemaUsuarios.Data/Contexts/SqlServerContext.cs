using Microsoft.EntityFrameworkCore;
using SistemaUsuarios.Data.Entities;
using SistemaUsuarios.Data.Mappings;

namespace SistemaUsuarios.Data.Contexts
{
    /// <summary>
    /// Classe para acessar o banco de dados do SqlServer
    /// através do EntityFramework (classe de conexão com o BD)
    /// </summary>
    public class SqlServerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=PAULONOTE;Initial Catalog=DBDELIVERY_USER;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new HistoricoMap());
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Historico> Historico { get; set; }

    }
}
