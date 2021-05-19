﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataAccess.Migrations
{
    [DbContext(typeof(AplicacionVentasContext))]
    partial class AplicacionVentasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Entities.EntidadCliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Estatus")
                        .HasColumnType("boolean");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            Estatus = true,
                            NombreCliente = "Quaker State"
                        });
                });

            modelBuilder.Entity("Entities.EntidadEmpleado", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ApMaterno")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("ApPaterno")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<bool>("Estatus")
                        .HasColumnType("boolean");

                    b.Property<string>("NombreEmpleado")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("integer");

                    b.Property<string>("PuestoEmpleado")
                        .HasColumnType("text");

                    b.HasKey("EmpleadoId");

                    b.HasIndex("ProyectoId");

                    b.ToTable("Empleados");

                    b.HasData(
                        new
                        {
                            EmpleadoId = 1,
                            ApMaterno = "DURAN",
                            ApPaterno = "BRAVO",
                            Estatus = true,
                            NombreEmpleado = "ELSA VERONICA",
                            ProyectoId = 1,
                            PuestoEmpleado = "Vendedor"
                        },
                        new
                        {
                            EmpleadoId = 2,
                            ApMaterno = "RODRIGUEZ",
                            ApPaterno = "ALVARADO",
                            Estatus = true,
                            NombreEmpleado = "NADIA AMAYRANI",
                            ProyectoId = 1,
                            PuestoEmpleado = "Vendedor"
                        },
                        new
                        {
                            EmpleadoId = 3,
                            ApMaterno = "ARELLANO",
                            ApPaterno = "CARREON",
                            Estatus = true,
                            NombreEmpleado = "MARIA DE JESUS",
                            ProyectoId = 2,
                            PuestoEmpleado = "Vendedor"
                        });
                });

            modelBuilder.Entity("Entities.EntidadEvidencia", b =>
                {
                    b.Property<int>("EvidenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("FechaCaptura")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Foto")
                        .HasColumnType("text");

                    b.HasKey("EvidenciaId");

                    b.HasIndex("EmpleadoId");

                    b.ToTable("Evidencias");

                    b.HasData(
                        new
                        {
                            EvidenciaId = 1,
                            EmpleadoId = 1,
                            FechaCaptura = new DateTime(2021, 5, 19, 12, 32, 16, 427, DateTimeKind.Local).AddTicks(1893),
                            Foto = "TestURL"
                        });
                });

            modelBuilder.Entity("Entities.EntidadProducto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DescripcionProducto")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("character varying(600)");

                    b.Property<bool>("Estatus")
                        .HasColumnType("boolean");

                    b.Property<string>("Marca")
                        .HasColumnType("text");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            DescripcionProducto = "25W50",
                            Estatus = true,
                            Marca = "Quaker State",
                            NombreProducto = "QS MAXIMA VISCOSIDAD SAE 25W50 CF4"
                        },
                        new
                        {
                            ProductoId = 2,
                            DescripcionProducto = "GREEN OIL",
                            Estatus = true,
                            Marca = "Quaker State",
                            NombreProducto = "QS GREEN OIL SAE 140"
                        },
                        new
                        {
                            ProductoId = 3,
                            DescripcionProducto = "Anticongelante",
                            Estatus = true,
                            Marca = "Quaker State",
                            NombreProducto = "ANTICONGELANTE CONCENTRACION IDEAL"
                        });
                });

            modelBuilder.Entity("Entities.EntidadProyecto", b =>
                {
                    b.Property<int>("ProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("integer");

                    b.Property<bool>("Estatus")
                        .HasColumnType("boolean");

                    b.Property<string>("Municipio")
                        .HasColumnType("text");

                    b.Property<string>("NombreProyecto")
                        .HasColumnType("text");

                    b.HasKey("ProyectoId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Proyectos");

                    b.HasData(
                        new
                        {
                            ProyectoId = 1,
                            ClienteId = 1,
                            Estatus = true,
                            Municipio = "Ciudad de Mexico",
                            NombreProyecto = "Promotoria Quaker State - CDMX"
                        },
                        new
                        {
                            ProyectoId = 2,
                            ClienteId = 1,
                            Estatus = true,
                            Municipio = "Monterrey",
                            NombreProyecto = "Promotoria Quaker State - Monterrey"
                        });
                });

            modelBuilder.Entity("Entities.EntidadVenta", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("integer");

                    b.Property<string>("DescripcionProducto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("FechaCaptura")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("FechaVenta")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("VentaId");

                    b.HasIndex("EmpleadoId");

                    b.ToTable("Ventas");

                    b.HasData(
                        new
                        {
                            VentaId = 1,
                            Cantidad = 3,
                            DescripcionProducto = "25W50",
                            EmpleadoId = 1,
                            FechaCaptura = new DateTime(2021, 5, 19, 12, 32, 16, 426, DateTimeKind.Local).AddTicks(7451),
                            FechaVenta = new DateTime(2021, 5, 19, 12, 32, 16, 421, DateTimeKind.Local).AddTicks(2050),
                            NombreProducto = "QS MAXIMA VISCOSIDAD SAE 25W50 CF4"
                        },
                        new
                        {
                            VentaId = 2,
                            Cantidad = 3,
                            DescripcionProducto = "GREEN OIL",
                            EmpleadoId = 2,
                            FechaCaptura = new DateTime(2021, 5, 19, 12, 32, 16, 426, DateTimeKind.Local).AddTicks(8847),
                            FechaVenta = new DateTime(2021, 5, 19, 12, 32, 16, 426, DateTimeKind.Local).AddTicks(8814),
                            NombreProducto = "QS GREEN OIL SAE 140"
                        },
                        new
                        {
                            VentaId = 3,
                            Cantidad = 3,
                            DescripcionProducto = "Anticongelante",
                            EmpleadoId = 3,
                            FechaCaptura = new DateTime(2021, 5, 19, 12, 32, 16, 426, DateTimeKind.Local).AddTicks(8865),
                            FechaVenta = new DateTime(2021, 5, 19, 12, 32, 16, 426, DateTimeKind.Local).AddTicks(8858),
                            NombreProducto = "ANTICONGELANTE CONCENTRACION IDEAL"
                        });
                });

            modelBuilder.Entity("Entities.EntidadEmpleado", b =>
                {
                    b.HasOne("Entities.EntidadProyecto", "Proyecto")
                        .WithMany("Empleado")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyecto");
                });

            modelBuilder.Entity("Entities.EntidadEvidencia", b =>
                {
                    b.HasOne("Entities.EntidadEmpleado", "Empleado")
                        .WithMany("Evidencia")
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Entities.EntidadProyecto", b =>
                {
                    b.HasOne("Entities.EntidadCliente", "Cliente")
                        .WithMany("Proyectos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Entities.EntidadVenta", b =>
                {
                    b.HasOne("Entities.EntidadEmpleado", "Empleado")
                        .WithMany("Ventas")
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Entities.EntidadCliente", b =>
                {
                    b.Navigation("Proyectos");
                });

            modelBuilder.Entity("Entities.EntidadEmpleado", b =>
                {
                    b.Navigation("Evidencia");

                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Entities.EntidadProyecto", b =>
                {
                    b.Navigation("Empleado");
                });
#pragma warning restore 612, 618
        }
    }
}
