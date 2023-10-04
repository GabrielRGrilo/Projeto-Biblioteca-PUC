using Microsoft.EntityFrameworkCore;

namespace Projeto_Biblioteca.Models {
    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios{ get; set; }
        public DbSet<Livro> Livros{ get; set; }
    }
}
