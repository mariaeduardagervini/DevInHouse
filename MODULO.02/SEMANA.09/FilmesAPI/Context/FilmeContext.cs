using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;
namespace FilmeApiCodeFirst.Context
{
    public class FilmeContext : DbContext
    {
        public FilmeContext()
        {
        }

        public FilmeContext(DbContextOptions<FilmeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Filme> Filmes { get; set; }

        //public virtual DbSet<Diretor> Diretores { get; set; }
        //public virtual DbSet<FilmeDiretor> FilmeDiretores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("ServerConnection");
            }
        }
    }
}