using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Usuarios.Controllers
{
    public class UsuariosController : Controller
    {
        //[HttpGet]
        public IActionResult Index(String data, int age)
        {
            //ViewData["id"] = data + " " + age;
            String datos = data + " " + age;
            return View("Index", datos);
        }
    }
}
