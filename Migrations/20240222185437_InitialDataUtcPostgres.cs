using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectef.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataUtcPostgres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TaskId",
                keyValue: new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008876"),
                columns: new[] { "Date", "Deadline" },
                values: new object[] { new DateTime(2024, 2, 22, 18, 54, 37, 844, DateTimeKind.Utc).AddTicks(9790), new DateTime(2024, 2, 23, 18, 54, 37, 844, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TaskId",
                keyValue: new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008877"),
                columns: new[] { "Date", "Deadline" },
                values: new object[] { new DateTime(2024, 2, 22, 18, 54, 37, 844, DateTimeKind.Utc).AddTicks(9810), new DateTime(2024, 2, 24, 18, 54, 37, 844, DateTimeKind.Utc).AddTicks(9810) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TaskId",
                keyValue: new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008876"),
                columns: new[] { "Date", "Deadline" },
                values: new object[] { new DateTime(2024, 2, 22, 7, 58, 43, 436, DateTimeKind.Local).AddTicks(8670), new DateTime(2024, 2, 23, 7, 58, 43, 436, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TaskId",
                keyValue: new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008877"),
                columns: new[] { "Date", "Deadline" },
                values: new object[] { new DateTime(2024, 2, 22, 7, 58, 43, 436, DateTimeKind.Local).AddTicks(8710), new DateTime(2024, 2, 24, 7, 58, 43, 436, DateTimeKind.Local).AddTicks(8710) });
        }
    }
}
