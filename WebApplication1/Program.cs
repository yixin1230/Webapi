using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using NSwag.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//Configure Swagger middleware for vs code (if you are using visual studio, you don't need this step)
//Enable the API Explorer, which is a service that provides metadara about the HTTP API. the API Explorer is used by
//Swagger to generate the Swagger document.
builder.Services.AddEndpointsApiExplorer();

//Add the Swagger OpenApi Document generator to the application services and configures it to provide more infomation about the API
//such as its title and version.
builder.Services.AddOpenApiDocument(config => {
    config.DocumentName = "WebApplication1";
    config.Title = "TodoAPI v1";
    config.Version = "v1";
});

var app = builder.Build();

//Enable the Swagger middleware for serving the generated JSON document and the Swagger UI.
//Swagger is only enabled in a development environment.
//Enabling Swagger in a production environment could expose potentially sensitive details about the API's structure and implementation
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi(config =>
    {
        config.DocumentTitle = "TodoAPI";
        config.Path = "/swagger";
        config.DocumentPath = "/swagger/{documentName}/swagger.json";
        config.DocExpansion = "list";
    });
}

//The sample app implements several GET endpoints by calling MapGet:
//Get all to-do items
app.MapGet("/todoitems", async (TodoDb db) =>
    await db.Todos.ToListAsync());

//Get all completed to-do items
app.MapGet("/todoitems/complete", async (TodoDb db) =>
    await db.Todos.Where(t => t.IsComplete).ToListAsync());

//Get an item by ID
app.MapGet("/todoitems/{id}", async (int id, TodoDb db) =>
    await db.Todos.FindAsync(id)
        is Todo todo
            ? Results.Ok(todo)
            : Results.NotFound());

//creates an HTTP POST endpoint /todoitems that adds data to the in-memory database:
app.MapPost("/todoitems", async (Todo todo, TodoDb db) =>
{
    db.Todos.Add(todo);
    await db.SaveChangesAsync();

    return Results.Created($"/todoitems/{todo.Id}", todo);
});

//The sample app implements a single PUT endpoint using MapPut:
app.MapPut("/todoitems/{id}", async (int id, Todo inputTodo, TodoDb db) =>
{
    var todo = await db.Todos.FindAsync(id);

    if (todo is null) return Results.NotFound();

    todo.Name = inputTodo.Name;
    todo.IsComplete = inputTodo.IsComplete;

    await db.SaveChangesAsync();

    return Results.NoContent();
});

//The sample app implements a single DELETE endpoint using MapDelete
app.MapDelete("/todoitems/{id}", async (int id, TodoDb db) =>
{
    if (await db.Todos.FindAsync(id) is Todo todo)
    {
        db.Todos.Remove(todo);
        await db.SaveChangesAsync();
        return Results.NoContent();
    }

    return Results.NotFound();
});

app.Run();
