﻿// <auto-generated />
using System;
using JCalentadores.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JCalentadores.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220910034935_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Historial", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("idUsuarioid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("idUsuarioid");

                    b.ToTable("HistorialCitas");
                });

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

                    b.Property<string>("nombreServicio")
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

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("admin")
                        .HasColumnType("bit");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cedula")
                        .HasColumnType("int");

                    b.Property<bool>("confirmado")
                        .HasColumnType("bit");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Usuario");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Usuarios");
                });

            modelBuilder.Entity("Cliente", b =>
                {
                    b.HasBaseType("Usuarios");

                    b.Property<int>("metodoPago")
                        .HasColumnType("int");

                    b.Property<int>("tipoPersona")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("Tecnico", b =>
                {
                    b.HasBaseType("Usuarios");

                    b.Property<DateTime>("horarioTecnico")
                        .HasColumnType("datetime2");

                    b.Property<int>("numeroRegistro")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Tecnico");
                });

            modelBuilder.Entity("Historial", b =>
                {
                    b.HasOne("Usuarios", "idUsuario")
                        .WithMany()
                        .HasForeignKey("idUsuarioid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("idUsuario");
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