using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NT1B_wAuthentication.Models;

namespace NT1B_wAuthentication.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


 

        public IActionResult Add(string nombre, string apellido)
        {
            ////todo lo que necesite.
            Persona elusuario = new Persona();
            elusuario.Nombre = nombre;
            elusuario.Apellido = "Picapiedra";

            nombre = "Mariano";

            ViewBag.MiNombre = nombre;
            ViewData["Nom"] = nombre;
            TempData["Nom"] = nombre;

            return View(elusuario);
        }



        //
    }
}