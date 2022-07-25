using System.Text;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataContext>(options => 
{
    options.UseSqlite("Data Source=data.db");
});

builder.Services.AddScoped<IFilmeRepo, FilmeRepoSqlite>();


var app = builder.Build();

app.MapGet("/", (HttpContext context) => // HttpContext context agora sei que sera um html
{
    context.Response.ContentType = "text/html;charset=utf-8";
    StringBuilder html = new StringBuilder();
    html.Append("<html><head>");
    html.Append("<link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css'>");

    html.Append("</head><body><div class='container'>");
    html.Append("<h1>Catálogo de Filmes</h1>");
    html.Append("<hr/>");
    html.Append("<a href='/filmes'>Todos os Filmes</a>");
    html.Append("</div></body><html>");


    return html.ToString();
});

app.MapGet("/filmes", (HttpContext context, IFilmeRepo repo) => // HttpContext context agora sei que sera um html
{
    context.Response.ContentType = "text/html;charset=utf-8";
    StringBuilder html = new StringBuilder();
    var filmes = repo.ObterTodosOsFilmes();
    html.Append("<html><head>");
    html.Append("<link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css'>");
    html.Append("</head><body><div class='container'>");
    html.Append("<h1>Todos os filmes</h1>");
    html.Append("<hr/>");
    html.Append("<a href='/'>Voltar a principal</a>");

    html.Append("<table class='table table-striped'><thead><tr>");
    html.Append("<th>Título</th><th>Avaliação</th><th>Duração(min.)</th></tr></thead><tbody>");

    foreach (var f in filmes)
    {
        html.Append($"<tr><td>{f.Titulo}</td>");
        html.Append($"<td>{f.Avaliacao}</td>");
        html.Append($"<td>{f.Duracao}</td></tr>");
    }


    html.Append("</tbody></table>");
    html.Append("</div></body><html>");


    return html.ToString();
});

app.Run();
