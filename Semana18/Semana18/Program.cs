
// cria o servidor http
var builder = WebApplication.CreateBuilder(args); 

// adiciona recursos/serviçoes de controllers e views (MVC)
builder.Services.AddControllersWithViews();

// inicializa a aplicação
var app = builder.Build();

// se não estiver em modo "Desenvolvimento"...
if (!app.Environment.IsDevelopment()) // isto é configurado em .vscode no lauch.json
{
    // usa uma página de exceção amigavel
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}


// força o uso de https
app.UseHttpsRedirection();

// habilitar arquivos estáticos(CSS, JS, PNG, JPG...)
app.UseStaticFiles();

// habilita o roteamento de URL, por donnde vas a solicitación
app.UseRouting();

// habilita o recurso de autorização. O que tens autorização para acessar 
app.UseAuthorization();


//cumo eres seul padrom de roteamientu 
// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}");

//app.UseMvcWithDefaultRoute();

app.MapDefaultControllerRoute();
app.Run();

