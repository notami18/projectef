using projectef;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddDbContext<TaksContext>(p => p.UseInMemoryDatabase("TasksDB"));
builder.Services.AddNpgsql<TaksContext>(builder.Configuration.GetConnectionString("TasksDBPostgres"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbConnection", ([FromServices] TaksContext dbContext) =>
{
  dbContext.Database.EnsureCreated();
  return Results.Ok($"Connection to the database {dbContext.Database.IsInMemory()} is successful");
});

app.MapGet("/api/tareas", ([FromServices] TaksContext dbContext) =>
{
  var tasks = dbContext.Tasks.Include(p => p.Category).ToList();
  return Results.Ok(tasks);
});

app.MapPost("/api/tareas", async ([FromServices] TaksContext dbContext, [FromBody] projectef.Models.Task task) =>
{
  task.TaskId = Guid.NewGuid();
  task.Date = DateTime.UtcNow;
  await dbContext.Tasks.AddAsync(task);
  await dbContext.SaveChangesAsync();
  return Results.Created($"/api/tareas/{task.TaskId}", task);
});

app.MapPut("/api/tareas/{id}", async ([FromServices] TaksContext dbContext, Guid id, [FromBody] projectef.Models.Task task) =>
{
  var taskToUpdate = await dbContext.Tasks.FindAsync(id);
  if (taskToUpdate is null)
  {
    return Results.NotFound();
  }
  taskToUpdate.Title = task.Title;
  taskToUpdate.Description = task.Description;
  taskToUpdate.PriorityTask = task.PriorityTask;
  taskToUpdate.Deadline = task.Deadline;
  dbContext.Tasks.Update(taskToUpdate);
  await dbContext.SaveChangesAsync();
  return Results.NoContent();
});

app.MapDelete("/api/tareas/{id}", async ([FromServices] TaksContext dbContext, Guid id) =>
{
  var taskToDelete = await dbContext.Tasks.FindAsync(id);
  if (taskToDelete is null)
  {
    return Results.NotFound();
  }
  dbContext.Tasks.Remove(taskToDelete);
  await dbContext.SaveChangesAsync();
  return Results.NoContent();
});

app.Run();
