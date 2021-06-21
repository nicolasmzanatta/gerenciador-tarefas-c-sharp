﻿// <auto-generated />
using System;
using GerenciadorDeTarefas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GerenciadorDeTarefas.Migrations
{
    [DbContext(typeof(GerenciadorDeTarefasContext))]
    partial class GerenciadorDeTarefasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GerenciadorDeTarefas.Models.Tarefa", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("DataConclusao")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("DataPrevistaConclusao")
                    .HasColumnType("datetime2");

                b.Property<int>("IdUsuario")
                    .HasColumnType("int");

                b.Property<string>("Nome")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("IdUsuario");

                b.ToTable("Tarefa");
            });

            modelBuilder.Entity("GerenciadorDeTarefas.Models.Usuario", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Email")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Nome")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Senha")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Usuario");
            });

            modelBuilder.Entity("GerenciadorDeTarefas.Models.Tarefa", b =>
            {
                b.HasOne("GerenciadorDeTarefas.Models.Usuario", "usuario")
                    .WithMany("Tarefas")
                    .HasForeignKey("IdUsuario")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("usuario");
            });

            modelBuilder.Entity("GerenciadorDeTarefas.Models.Usuario", b =>
            {
                b.Navigation("Tarefas");
            });
#pragma warning restore 612, 618
        }
    }
}