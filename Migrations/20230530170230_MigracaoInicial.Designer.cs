﻿// <auto-generated />
using System;
using ApiUniversidade.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace apiUniversidade.Migrations
{
    [DbContext(typeof(ApiUniversidadeContext))]
    [Migration("20230530170230_MigracaoInicial")]
    partial class MigracaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Escola.Model.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("Escola.Model.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AlunoId")
                        .HasColumnType("integer");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Duracao")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("Escola.Model.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AlunoId")
                        .HasColumnType("integer");

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("integer");

                    b.Property<int?>("CursoId")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<int>("Semestre")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("CursoId");

                    b.ToTable("Disciplinas");
                });

            modelBuilder.Entity("Escola.Model.Curso", b =>
                {
                    b.HasOne("Escola.Model.Aluno", null)
                        .WithMany("cursos")
                        .HasForeignKey("AlunoId");
                });

            modelBuilder.Entity("Escola.Model.Disciplina", b =>
                {
                    b.HasOne("Escola.Model.Aluno", null)
                        .WithMany("disciplinas")
                        .HasForeignKey("AlunoId");

                    b.HasOne("Escola.Model.Curso", null)
                        .WithMany("disciplinas")
                        .HasForeignKey("CursoId");
                });

            modelBuilder.Entity("Escola.Model.Aluno", b =>
                {
                    b.Navigation("cursos");

                    b.Navigation("disciplinas");
                });

            modelBuilder.Entity("Escola.Model.Curso", b =>
                {
                    b.Navigation("disciplinas");
                });
#pragma warning restore 612, 618
        }
    }
}
