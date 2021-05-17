using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class dos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "VentaId",
                keyValue: 1,
                columns: new[] { "FechaCaptura", "FechaVenta" },
                values: new object[] { new DateTime(2021, 5, 17, 14, 7, 57, 71, DateTimeKind.Local).AddTicks(7340), new DateTime(2021, 5, 17, 14, 7, 57, 67, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "VentaId",
                keyValue: 2,
                columns: new[] { "FechaCaptura", "FechaVenta" },
                values: new object[] { new DateTime(2021, 5, 17, 14, 7, 57, 71, DateTimeKind.Local).AddTicks(8378), new DateTime(2021, 5, 17, 14, 7, 57, 71, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "VentaId",
                keyValue: 3,
                columns: new[] { "FechaCaptura", "FechaVenta" },
                values: new object[] { new DateTime(2021, 5, 17, 14, 7, 57, 71, DateTimeKind.Local).AddTicks(8389), new DateTime(2021, 5, 17, 14, 7, 57, 71, DateTimeKind.Local).AddTicks(8384) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "VentaId",
                keyValue: 1,
                columns: new[] { "FechaCaptura", "FechaVenta" },
                values: new object[] { new DateTime(2021, 5, 17, 11, 46, 19, 190, DateTimeKind.Local).AddTicks(8566), new DateTime(2021, 5, 17, 11, 46, 19, 184, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "VentaId",
                keyValue: 2,
                columns: new[] { "FechaCaptura", "FechaVenta" },
                values: new object[] { new DateTime(2021, 5, 17, 11, 46, 19, 191, DateTimeKind.Local).AddTicks(4), new DateTime(2021, 5, 17, 11, 46, 19, 190, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "VentaId",
                keyValue: 3,
                columns: new[] { "FechaCaptura", "FechaVenta" },
                values: new object[] { new DateTime(2021, 5, 17, 11, 46, 19, 191, DateTimeKind.Local).AddTicks(22), new DateTime(2021, 5, 17, 11, 46, 19, 191, DateTimeKind.Local).AddTicks(14) });
        }
    }
}
