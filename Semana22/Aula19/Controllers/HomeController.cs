using Aula19.Data;
using Aula19.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aula19.Controllers;

public class HomeController : Controller
{

    private readonly AppDbContext _db;

    public HomeController(AppDbContext db){
        _db = db;
    }

    public IActionResult Index()
    {
        //RockStar me = new RockStar(1, "Michael Jackson", "michael@gmail.com");
        var rockStars = _db.RockStars.AsNoTracking().ToList();
        return View(rockStars);
        //return Content("<h1>Este é um texto simples.</h1>", "text/html;charset=utf-8");
        //return File("C:\\Users\\2152606\\Documents\\PW\\G1\\Aula19\\wwwroot\\teste.txt", "application/txt");
        //return Json(me);
    }

    public IActionResult Detalhes(int id)
    {
        // var rs = _db.RockStars.FirstOrDefault(r => r.Id == id); // busca propriedades que não seja chave
        var rs = _db.RockStars.Find(id);
        return View(rs);
    }
}