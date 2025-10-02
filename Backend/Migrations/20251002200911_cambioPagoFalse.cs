using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class cambioPagoFalse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaHora",
                value: new DateTime(2025, 10, 12, 17, 9, 9, 118, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaHora",
                value: new DateTime(2025, 10, 22, 17, 9, 9, 118, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaHora",
                value: new DateTime(2025, 10, 17, 17, 9, 9, 118, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaHora",
                value: new DateTime(2025, 11, 1, 17, 9, 9, 118, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaHora",
                value: new DateTime(2025, 10, 27, 17, 9, 9, 118, DateTimeKind.Local).AddTicks(7710));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaHora",
                value: new DateTime(2025, 10, 12, 17, 6, 20, 205, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaHora",
                value: new DateTime(2025, 10, 22, 17, 6, 20, 205, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaHora",
                value: new DateTime(2025, 10, 17, 17, 6, 20, 205, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaHora",
                value: new DateTime(2025, 11, 1, 17, 6, 20, 205, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaHora",
                value: new DateTime(2025, 10, 27, 17, 6, 20, 205, DateTimeKind.Local).AddTicks(7874));
        }
    }
}
