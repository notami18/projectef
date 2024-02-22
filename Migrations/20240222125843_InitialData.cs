using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace projectef.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoryId", "Description", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008874"), "Tareas pendientes", "Actividades pendientes", 20 },
                    { new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008875"), "Tareas personales", "Actividades personales", 50 }
                });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TaskId", "CategoryId", "Date", "Deadline", "Description", "PriorityTask", "Title" },
                values: new object[,]
                {
                    { new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008876"), new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008874"), new DateTime(2024, 2, 22, 7, 58, 43, 436, DateTimeKind.Local).AddTicks(8670), new DateTime(2024, 2, 23, 7, 58, 43, 436, DateTimeKind.Local).AddTicks(8700), "Pagos adicionales de servicios publicos", 1, "Pago servicios publicos" },
                    { new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008877"), new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008875"), new DateTime(2024, 2, 22, 7, 58, 43, 436, DateTimeKind.Local).AddTicks(8710), new DateTime(2024, 2, 24, 7, 58, 43, 436, DateTimeKind.Local).AddTicks(8710), null, 0, "Terminar de ver pelicula en netflix" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TaskId",
                keyValue: new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008876"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TaskId",
                keyValue: new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008877"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoryId",
                keyValue: new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008874"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoryId",
                keyValue: new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008875"));
        }
    }
}
