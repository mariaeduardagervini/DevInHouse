﻿using System;
using Escola.API.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Escola.API.Migrations
{
    [DbContext(typeof(EscolaDbContexto))]
    [Migration("20230704230405_criar aluno")]
    partial class criaraluno
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Escola.API.Model.Aluno", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("DataNascimento")
                    .HasColumnType("datetime2");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("VARCHAR");

                b.Property<string>("Genero")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Idade")
                    .HasColumnType("int");

                b.Property<string>("Nome")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.Property<string>("Sobrenome")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Telefone")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id")
                    .HasName("Pk_aluno_id");

                b.ToTable("AlunoTB");
            });
#pragma warning restore 612, 618
        }
    }
}