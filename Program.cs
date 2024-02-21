using projectef;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

app.Run();
