using Microsoft.AspNetCore.Mvc;
using Semana16.Models;

namespace Semana16.Controllers;

public class UsuarioController : Controller
{
    
    private List<Usuario> _usuarios;
    
    
    public UsuarioController()
    {
        _usuarios = new List<Usuario>();
        _usuarios.Add(new Usuario{IdUsuario=1, Nome="Usuario1", Email="usuario1@gmail.com", Telefone = "99999-9991", DataNascimento = DateTime.Now.AddYears(-19)});
        _usuarios.Add(new Usuario{IdUsuario=2, Nome="Usuario2", Email="usuario2@gmail.com", Telefone = "99999-9992", DataNascimento = DateTime.Now.AddYears(-29)});
        _usuarios.Add(new Usuario{IdUsuario=3, Nome="Usuario3", Email="usuario3@gmail.com", Telefone = "99999-9993", DataNascimento = DateTime.Now.AddYears(-39)});
    }
    
    public IActionResult Index()
    {
        return View(_usuarios);
    }

    public IActionResult Detalhes(int id)
    {
        var usuarioSelecionado = _usuarios.FirstOrDefault(u => u.IdUsuario == id);
        return View(usuarioSelecionado);
    }

}