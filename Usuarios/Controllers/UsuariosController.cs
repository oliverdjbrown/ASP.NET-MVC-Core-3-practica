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
        [Route("/Usuarios/Oliver")]
        [Route("[controller]/[action]/{data}")]
        public IActionResult Index(String data, int age)
        {            
            String datos = data + " " + age;
            return View("Index", datos);
        }

        public IActionResult Index()
        {            
            return View();
        }
    }
}
 