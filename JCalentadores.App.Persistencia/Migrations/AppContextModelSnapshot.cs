﻿// <auto-generated />
using System;
using JCalentadores.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JCalentadores.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JCalentadores.App.Dominio.Citas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("UsuarioIdid")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaHora")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("UsuarioIdid");

                    b.ToTable("Cita");
                });

            modelBuilder.Entity("JCalentadores.App.Dominio.CitasServicios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("citaIdid")
                        .HasColumnType("int");

                    b.Property<int>("servicioIdid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("citaIdid");

                    b.HasIndex("servicioIdid");

                    b.ToTable("CitaServicio");
                });

            modelBuilder.Entity("Servicios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("precio")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Servicio");
                });

            modelBuilder.Entity("Usuarios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("JCalentadores.App.Dominio.Citas", b =>
                {
                    b.HasOne("Usuarios", "UsuarioId")
                        .WithMany()
                        .HasForeignKey("UsuarioIdid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsuarioId");
                });

            modelBuilder.Entity("JCalentadores.App.Dominio.CitasServicios", b =>
                {
                    b.HasOne("JCalentadores.App.Dominio.Citas", "citaId")
                        .WithMany()
                        .HasForeignKey("citaIdid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Servicios", "servicioId")
                        .WithMany()
                        .HasForeignKey("servicioIdid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("citaId");

                    b.Navigation("servicioId");
                });
#pragma warning restore 612, 618
        }
    }
}