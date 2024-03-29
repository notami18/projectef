﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using projectef;

#nullable disable

namespace projectef.Migrations
{
    [DbContext(typeof(TaksContext))]
    [Migration("20240222185631_AddDefaultValueToCreatedAtOnTaskTable")]
    partial class AddDefaultValueToCreatedAtOnTaskTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("projectef.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<int>("Weight")
                        .HasColumnType("integer");

                    b.HasKey("CategoryId");

                    b.ToTable("Categoria", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008874"),
                            Description = "Tareas pendientes",
                            Name = "Actividades pendientes",
                            Weight = 20
                        },
                        new
                        {
                            CategoryId = new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008875"),
                            Description = "Tareas personales",
                            Name = "Actividades personales",
                            Weight = 50
                        });
                });

            modelBuilder.Entity("projectef.Models.Task", b =>
                {
                    b.Property<Guid>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("PriorityTask")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("TaskId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Tarea", (string)null);

                    b.HasData(
                        new
                        {
                            TaskId = new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008876"),
                            CategoryId = new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008874"),
                            Date = new DateTime(2024, 2, 22, 18, 56, 31, 609, DateTimeKind.Utc).AddTicks(670),
                            Deadline = new DateTime(2024, 2, 23, 18, 56, 31, 609, DateTimeKind.Utc).AddTicks(670),
                            Description = "Pagos adicionales de servicios publicos",
                            PriorityTask = 1,
                            Title = "Pago servicios publicos"
                        },
                        new
                        {
                            TaskId = new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008877"),
                            CategoryId = new Guid("9d4d244f-d5cf-4b5d-a6f8-c585c6008875"),
                            Date = new DateTime(2024, 2, 22, 18, 56, 31, 609, DateTimeKind.Utc).AddTicks(680),
                            Deadline = new DateTime(2024, 2, 24, 18, 56, 31, 609, DateTimeKind.Utc).AddTicks(680),
                            PriorityTask = 0,
                            Title = "Terminar de ver pelicula en netflix"
                        });
                });

            modelBuilder.Entity("projectef.Models.Task", b =>
                {
                    b.HasOne("projectef.Models.Category", "Category")
                        .WithMany("Tasks")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("projectef.Models.Category", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
