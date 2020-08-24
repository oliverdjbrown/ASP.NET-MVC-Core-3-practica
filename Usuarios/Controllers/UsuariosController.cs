using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Usuarios.Controllers
{
    // [Route("[controller]")]
    public class UsuariosController : Controller
    {
        //[HttpGet]
        //[Route("/Usuarios/Oliver")]
        //[HttpGet("[controller]/[action]/{data:int}")]
        public IActionResult Index(int data) 
        {
            //var url = Url.Action("Metodo", "Usuarios",new { age=30, name="Oliver" });
            //return View("Index", data);
            var url = Url.RouteUrl("Oliver", new { age = 30, name = "Oliver" });
            return Redirect(url);
        }
        [HttpGet("[controller]/[action]", Name ="Oliver")]
        public IActionResult Metodo(int age, string name)
        {
            var data = $"Nombre {name} edad {age}";
            return View("Index", data);
        }
    }
}
 