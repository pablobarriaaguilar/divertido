using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using divertido.Models;

namespace divertido.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string myViewModelString = "este es un mensaje de viewmodel enviado como parametro!";
        return View("Index",myViewModelString);
    }

    [HttpGet]
    [Route("/numbers")]
     public IActionResult Numbers()
    {
        int [] myViewModelInt = {1,2,3,4,5,6,25,23,21};
        return View("Numbers",myViewModelInt);
    }


    [HttpGet]
    [Route("/user")]
     public IActionResult User()
    {
        User usuario = new User();
        usuario.FirstName = "Pablo Barría";
        return View("User",usuario);
    }

    [HttpGet]
    [Route("/users")]
     public IActionResult Users()
    {
        User usuario1 = new User();
        usuario1.FirstName = "Pablo Barría";
        User usuario2 = new User();
        usuario2.FirstName = "Felipe Fuentes";
        User usuario3 = new User();
        usuario3.FirstName = "Ivan Haro";

        List <User> listausuarios = new List<User>();
        listausuarios.Add(usuario1);
        listausuarios.Add(usuario2);
        listausuarios.Add(usuario3);
        
        return View("Users",listausuarios);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
