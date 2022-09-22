using Microsoft.AspNetCore.Mvc;
using Semana19.Models;

namespace Semana19.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() 
    { 
        Usuario eu = new Usuario();
        eu.Id = 1;
        eu.Nome = "Renato";
        eu.Email = "renatoribeiroalto@gmail.com";
        return View(eu);
    }
}