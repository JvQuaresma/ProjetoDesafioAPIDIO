using Microsoft.EntityFrameworkCore;
using ProjetoDesafioApiDIO.Entities;


namespace ProjetoDesafioApiDIO.Context {
    public class OrganizadorContext : DbContext {

        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options) {

        }

        public DbSet<Tarefa> Tarefas { get; set; }

    }
}
