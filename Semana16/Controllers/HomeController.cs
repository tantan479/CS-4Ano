using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Semana16.Models;

namespace Semana16.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) // inicializa o objeto controlador com os serviços que serão usados
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(); //
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Membros()
    {
        return View();
    }
    public IActionResult ProvocarErro()
    {
        throw new NotImplementedException("Erro que eu quero");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
