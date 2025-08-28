using Microsoft.EntityFrameworkCore;
using SistemaTarefa.Data.Map;
using SistemaTarefa.Model;

namespace SistemaTarefa.Data
{

    public class SistemaTarefasDbContext : DbContext
    {
        public SistemaTarefasDbContext(DbContextOptions<SistemaTarefasDbContext> options)
    : base(options)
        {
        }

        public DbSet<TarefaModel> Tarefas { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Durante a criação de um novo banco(tabelas), ele aplica as regras que nós definimos
            // dentro do MAP
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
