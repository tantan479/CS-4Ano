using Microsoft.AspNetCore.Mvc;
using Semana20.Models;

namespace Semana20.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() 
    { 
        //RockStar eu = new RockStar(1, "Renato", "renatoribeiroalto@gmail.com");

        return View(RockStar.lista);
        //return Content("<h1>Este é um texto simples</h1>", "text/html;charset=utf-8"); // a rá agora mostro  como html
        //return File("C:\\Users\\20191IMI028\\Desktop\\4° ano\\PW\\Semana20\\guia.txt", "application/txt"); // ao contrario do use static files, eu pego arquivo de qualquer lugar do server e não apenas do wwwroot
        //return Json(eu);
    }

    public IActionResult Detalhes(int id)
    { 
        var rs = RockStar.lista.FirstOrDefault(r => r.Id == id);
        return View(rs);
    }

}
