using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectef.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultValueToCreatedAtOnTaskTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Deadline",
                table: "Tarea",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Tarea",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TaskId",
                keyValue: new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008876"),
                columns: new[] { "Date", "Deadline" },
                values: new object[] { new DateTime(2024, 2, 22, 18, 56, 31, 609, DateTimeKind.Utc).AddTicks(670), new DateTime(2024, 2, 23, 18, 56, 31, 609, DateTimeKind.Utc).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TaskId",
                keyValue: new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008877"),
                columns: new[] { "Date", "Deadline" },
                values: new object[] { new DateTime(2024, 2, 22, 18, 56, 31, 609, DateTimeKind.Utc).AddTicks(680), new DateTime(2024, 2, 24, 18, 56, 31, 609, DateTimeKind.Utc).AddTicks(680) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Deadline",
                table: "Tarea",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Tarea",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

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
    }
}
