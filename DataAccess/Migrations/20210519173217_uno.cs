using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataAccess.Migrations
{
    public partial class uno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreCliente = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Estatus = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreProducto = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: false),
                    DescripcionProducto = table.Column<string>(type: "character varying(600)", maxLength: 600, nullable: false),
                    Marca = table.Column<string>(type: "text", nullable: true),
                    Estatus = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                });

            migrationBuilder.CreateTable(
                name: "Proyectos",
                columns: table => new
                {
                    ProyectoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreProyecto = table.Column<string>(type: "text", nullable: true),
                    Municipio = table.Column<string>(type: "text", nullable: true),
                    Estatus = table.Column<bool>(type: "boolean", nullable: false),
                    ClienteId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.ProyectoId);
                    table.ForeignKey(
                        name: "FK_Proyectos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreEmpleado = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    ApPaterno = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    ApMaterno = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    ProyectoId = table.Column<int>(type: "integer", nullable: false),
                    PuestoEmpleado = table.Column<string>(type: "text", nullable: true),
                    Estatus = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoId);
                    table.ForeignKey(
                        name: "FK_Empleados_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "ProyectoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evidencias",
                columns: table => new
                {
                    EvidenciaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Foto = table.Column<string>(type: "text", nullable: true),
                    FechaCaptura = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EmpleadoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evidencias", x => x.EvidenciaId);
                    table.ForeignKey(
                        name: "FK_Evidencias_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    VentaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmpleadoId = table.Column<int>(type: "integer", nullable: false),
                    NombreProducto = table.Column<string>(type: "text", nullable: false),
                    DescripcionProducto = table.Column<string>(type: "text", nullable: false),
                    Cantidad = table.Column<int>(type: "integer", nullable: false),
                    FechaVenta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FechaCaptura = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.VentaId);
                    table.ForeignKey(
                        name: "FK_Ventas_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Estatus", "NombreCliente" },
                values: new object[] { 1, true, "Quaker State" });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "DescripcionProducto", "Estatus", "Marca", "NombreProducto" },
                values: new object[,]
                {
                    { 1, "25W50", true, "Quaker State", "QS MAXIMA VISCOSIDAD SAE 25W50 CF4" },
                    { 2, "GREEN OIL", true, "Quaker State", "QS GREEN OIL SAE 140" },
                    { 3, "Anticongelante", true, "Quaker State", "ANTICONGELANTE CONCENTRACION IDEAL" }
                });

            migrationBuilder.InsertData(
                table: "Proyectos",
                columns: new[] { "ProyectoId", "ClienteId", "Estatus", "Municipio", "NombreProyecto" },
                values: new object[,]
                {
                    { 1, 1, true, "Ciudad de Mexico", "Promotoria Quaker State - CDMX" },
                    { 2, 1, true, "Monterrey", "Promotoria Quaker State - Monterrey" }
                });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "EmpleadoId", "ApMaterno", "ApPaterno", "Estatus", "NombreEmpleado", "ProyectoId", "PuestoEmpleado" },
                values: new object[,]
                {
                    { 1, "DURAN", "BRAVO", true, "ELSA VERONICA", 1, "Vendedor" },
                    { 2, "RODRIGUEZ", "ALVARADO", true, "NADIA AMAYRANI", 1, "Vendedor" },
                    { 3, "ARELLANO", "CARREON", true, "MARIA DE JESUS", 2, "Vendedor" }
                });

            migrationBuilder.InsertData(
                table: "Evidencias",
                columns: new[] { "EvidenciaId", "EmpleadoId", "FechaCaptura", "Foto" },
                values: new object[] { 1, 1, new DateTime(2021, 5, 19, 12, 32, 16, 427, DateTimeKind.Local).AddTicks(1893), "TestURL" });

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "VentaId", "Cantidad", "DescripcionProducto", "EmpleadoId", "FechaCaptura", "FechaVenta", "NombreProducto" },
                values: new object[,]
                {
                    { 1, 3, "25W50", 1, new DateTime(2021, 5, 19, 12, 32, 16, 426, DateTimeKind.Local).AddTicks(7451), new DateTime(2021, 5, 19, 12, 32, 16, 421, DateTimeKind.Local).AddTicks(2050), "QS MAXIMA VISCOSIDAD SAE 25W50 CF4" },
                    { 2, 3, "GREEN OIL", 2, new DateTime(2021, 5, 19, 12, 32, 16, 426, DateTimeKind.Local).AddTicks(8847), new DateTime(2021, 5, 19, 12, 32, 16, 426, DateTimeKind.Local).AddTicks(8814), "QS GREEN OIL SAE 140" },
                    { 3, 3, "Anticongelante", 3, new DateTime(2021, 5, 19, 12, 32, 16, 426, DateTimeKind.Local).AddTicks(8865), new DateTime(2021, 5, 19, 12, 32, 16, 426, DateTimeKind.Local).AddTicks(8858), "ANTICONGELANTE CONCENTRACION IDEAL" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_ProyectoId",
                table: "Empleados",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_Evidencias_EmpleadoId",
                table: "Evidencias",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_ClienteId",
                table: "Proyectos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_EmpleadoId",
                table: "Ventas",
                column: "EmpleadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evidencias");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Proyectos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
