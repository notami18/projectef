using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projectef.Models;
using Microsoft.EntityFrameworkCore;

namespace projectef
{
  public class TaksContext : DbContext
  {
    public DbSet<Category> Categories { get; set; }
    public DbSet<projectef.Models.Task> Tasks { get; set; }
    public TaksContext(DbContextOptions<TaksContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      List<Category> categoriesInit = new()
      {
          new Category { CategoryId = Guid.Parse("9d4d244f-d5cf-4b5d-a6f8-c585c6008874"), Name = "Actividades pendientes", Description = "Tareas pendientes", Weight = 20 },
          new Category { CategoryId = Guid.Parse("9d4d244f-d5cf-4b5d-a6f8-c585c6008875"), Name = "Actividades personales", Description = "Tareas personales", Weight = 50 }
      };

      modelBuilder.Entity<Category>(category =>
      {
        category.ToTable("Categoria");
        category.HasKey(c => c.CategoryId);

        category.Property(c => c.Name)
          .IsRequired()
          .HasMaxLength(150);

        category.Property(c => c.Description);

        category.Property(c => c.Weight);

        category.HasData(categoriesInit);
      });

      List<projectef.Models.Task> tasksInit = new()
      {
          new projectef.Models.Task { TaskId = Guid.Parse("9d4d244f-d5cf-4b5d-a6f8-c585c6008876"), CategoryId = Guid.Parse("9d4d244f-d5cf-4b5d-a6f8-c585c6008874"), Title = "Pago servicios publicos", Description = "Pagos adicionales de servicios publicos", PriorityTask = Priority.Medium, Date = DateTime.UtcNow, Deadline = DateTime.UtcNow.AddDays(1) },
          new projectef.Models.Task { TaskId = Guid.Parse("9d4d244f-d5cf-4b5d-a6f8-c585c6008877"), CategoryId = Guid.Parse("9d4d244f-d5cf-4b5d-a6f8-c585c6008875"), Title = "Terminar de ver pelicula en netflix", PriorityTask = Priority.Low, Date = DateTime.UtcNow, Deadline = DateTime.UtcNow.AddDays(2) }
      };

      modelBuilder.Entity<projectef.Models.Task>(task =>
      {
        task.ToTable("Tarea");
        task.HasKey(t => t.TaskId);
        task.HasOne(t => t.Category)
          .WithMany(c => c.Tasks)
          .HasForeignKey(t => t.CategoryId);
        task.Property(t => t.Title)
          .IsRequired()
          .HasMaxLength(200);
        task.Property(t => t.Description);
        task.Property(t => t.PriorityTask);
        task.Property(t => t.Date);
        task.Property(t => t.Deadline);

        task.Ignore(t => t.Resumen);
        task.HasData(tasksInit);
      });
    }
  }
}