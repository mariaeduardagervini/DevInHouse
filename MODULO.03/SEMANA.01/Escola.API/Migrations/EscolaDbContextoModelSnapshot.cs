﻿using System;
using Escola.API.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Escola.API.Migrations
{
    [DbContext(typeof(EscolaDbContexto))]
    partial class EscolaDbContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {

            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Escola.API.Model.Aluno", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INT")
                    .HasColumnName("PK_ID")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("DataNascimento")
                    .HasColumnType("datetime2")
                    .HasColumnName("DATA_NASCIMENTO");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("VARCHAR(50)")
                    .HasColumnName("EMAIL");

                b.Property<string>("Genero")
                    .HasMaxLength(20)
                    .HasColumnType("VARCHAR(20)")
                    .HasColumnName("GENERO");

                b.Property<string>("Nome")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("VARCHAR(50)")
                    .HasColumnName("NOME");

                b.Property<string>("Sobrenome")
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnType("VARCHAR(150)")
                    .HasColumnName("SOBRENOME");

                b.Property<string>("Telefone")
                    .HasMaxLength(30)
                    .HasColumnType("VARCHAR(30)")
                    .HasColumnName("TELEFONE");

                b.HasKey("Id")
                    .HasName("Pk_aluno_id");

                b.HasIndex("Email")
                    .IsUnique();

                b.ToTable("AlunoTB");
            });

            modelBuilder.Entity("Escola.API.Model.Turma", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("ID")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Curso")
                    .ValueGeneratedOnAdd()
                    .HasMaxLength(50)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValue("Curso Basico")
                    .HasColumnName("CURSO");

                b.Property<string>("Nome")
                    .HasMaxLength(50)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("Nome");

                b.HasKey("Id");

                b.HasIndex("Nome")
                    .IsUnique()
                    .HasFilter("[Nome] IS NOT NULL");

                b.ToTable("TURMA");
            });
#pragma warning restore 612, 618
        }
    }
}