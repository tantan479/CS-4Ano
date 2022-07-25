using Microsoft.EntityFrameworkCore;
using Semana13.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataContext>(options => {
    options.UseSqlite("Data Source=data.db"); // nome do arquivo onde se encontra o banco de dados
});

var app = builder.Build();

app.MapGet("/", () => "Hello There!");

app.Run();
