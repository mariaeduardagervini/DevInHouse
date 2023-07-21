using Escola.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Escola.API.DataBase
{
    public class DbContexto : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("Db-auth");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasKey(x => x.Login);
            modelBuilder.Entity<Usuario>().Property(x => x.Login)
                                           .HasMaxLength(50);

            modelBuilder.Entity<Usuario>().Property(x => x.Senha)
                                          .HasMaxLength(50);
        }
    }
}
