﻿// <auto-generated />
using System;
using Intelligreen.Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Intelligreen.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231101071118_Crea cuidados")]
    partial class Creacuidados
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Intelligreen.Domain.Entity.Cuidado", b =>
                {
                    b.Property<Guid>("CuidadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("PlantaId")
                        .HasColumnType("uuid");

                    b.HasKey("CuidadoId");

                    b.HasIndex("PlantaId");

                    b.ToTable("Cuidados");
                });

            modelBuilder.Entity("Intelligreen.Domain.Entity.Planta", b =>
                {
                    b.Property<Guid>("PlantaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("CLasificacionCuidado")
                        .HasColumnType("integer");

                    b.Property<int>("ClasificacionAgua")
                        .HasColumnType("integer");

                    b.Property<int>("ClasificacionSol")
                        .HasColumnType("integer");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("HumedadAmbiente")
                        .HasColumnType("real");

                    b.Property<float>("HumedadTierra")
                        .HasColumnType("real");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NombreCientifico")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("TemperaturaAmbiente")
                        .HasColumnType("real");

                    b.HasKey("PlantaId");

                    b.ToTable("Plantas");
                });

            modelBuilder.Entity("Intelligreen.Domain.Entity.Cuidado", b =>
                {
                    b.HasOne("Intelligreen.Domain.Entity.Planta", null)
                        .WithMany("Cuidados")
                        .HasForeignKey("PlantaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Intelligreen.Domain.Entity.Planta", b =>
                {
                    b.Navigation("Cuidados");
                });
#pragma warning restore 612, 618
        }
    }
}
