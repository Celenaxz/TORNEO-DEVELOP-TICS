﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Torneo.App.Persistencia;

#nullable disable

namespace Torneo.App.Persistencia.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Torneo.App.Dominio.DirectorTecnico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DirectoresTecnicos");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DirectorTecnicoId")
                        .HasColumnType("int");

                    b.Property<int>("Municipioid")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DirectorTecnicoId");

                    b.HasIndex("Municipioid");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("PosicionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.HasIndex("PosicionId");

                    b.ToTable("Jugadores");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Municipio", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Partido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocalId")
                        .HasColumnType("int");

                    b.Property<int>("MarcadorLocal")
                        .HasColumnType("int");

                    b.Property<int>("MarcadorVisitante")
                        .HasColumnType("int");

                    b.Property<int>("VisitanteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocalId");

                    b.HasIndex("VisitanteId");

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Posicion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posiciones");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Equipo", b =>
                {
                    b.HasOne("Torneo.App.Dominio.DirectorTecnico", "DirectorTecnico")
                        .WithMany()
                        .HasForeignKey("DirectorTecnicoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Torneo.App.Dominio.Municipio", "Municipio")
                        .WithMany()
                        .HasForeignKey("Municipioid")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DirectorTecnico");

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Jugador", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Torneo.App.Dominio.Posicion", "Posicion")
                        .WithMany()
                        .HasForeignKey("PosicionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Equipo");

                    b.Navigation("Posicion");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Partido", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Equipo", "Local")
                        .WithMany()
                        .HasForeignKey("LocalId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Torneo.App.Dominio.Equipo", "Visitante")
                        .WithMany()
                        .HasForeignKey("VisitanteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Local");

                    b.Navigation("Visitante");
                });
#pragma warning restore 612, 618
        }
    }
}