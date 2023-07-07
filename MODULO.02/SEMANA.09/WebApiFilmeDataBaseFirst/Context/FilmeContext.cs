using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApiFilmeDataBaseFirst.Models;

namespace WebApiFilmeDataBaseFirst.Context;

public partial class FilmeContext : DbContext
{
    public FilmeContext()
    {
    }

    public FilmeContext(DbContextOptions<FilmeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Atore> Atores { get; set; }

    public virtual DbSet<Diretore> Diretores { get; set; }

    public virtual DbSet<ElencoFilme> ElencoFilmes { get; set; }

    public virtual DbSet<Filme> Filmes { get; set; }

    public virtual DbSet<FilmeDiretor> FilmeDiretors { get; set; }

    public virtual DbSet<FilmeGenero> FilmeGeneros { get; set; }

    public virtual DbSet<Genero> Generos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("ServerConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Atore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Ator");

            entity.Property(e => e.Genero)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Diretore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Diretor");

            entity.Property(e => e.Nome)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Telefone)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ElencoFilme>(entity =>
        {
            entity.ToTable("ElencoFilme");

            entity.Property(e => e.Papel)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAtorNavigation).WithMany(p => p.ElencoFilmes)
                .HasForeignKey(d => d.IdAtor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ElencoFilme__Atores");

            entity.HasOne(d => d.IdFilmeNavigation).WithMany(p => p.ElencoFilmes)
                .HasForeignKey(d => d.IdFilme)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ElencoFilme__Filmes");
        });

        modelBuilder.Entity<Filme>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Filme");

            entity.Property(e => e.Nome)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FilmeDiretor>(entity =>
        {
            entity.ToTable("FilmeDiretor");

            entity.HasOne(d => d.IdDiretorNavigation).WithMany(p => p.FilmeDiretors)
                .HasForeignKey(d => d.IdDiretor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FilmeDiretor__Diretor");

            entity.HasOne(d => d.IdFilmeNavigation).WithMany(p => p.FilmeDiretors)
                .HasForeignKey(d => d.IdFilme)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FilmeDiretor__Filme");
        });

        modelBuilder.Entity<FilmeGenero>(entity =>
        {
            entity.ToTable("FilmeGenero");

            entity.HasOne(d => d.IdFilmeNavigation).WithMany(p => p.FilmeGeneros)
                .HasForeignKey(d => d.IdFilme)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FilmeGenero__Filmes");

            entity.HasOne(d => d.IdGeneroNavigation).WithMany(p => p.FilmeGeneros)
                .HasForeignKey(d => d.IdGenero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FilmeGenero__Generos");
        });

        modelBuilder.Entity<Genero>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Genero");

            entity.Property(e => e.Genero1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Genero");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
