using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NT1B_wAuthentication.Models;
using NT1B_wAuthentication.Servicios;

namespace NT1B_wAuthentication.Controllers
{
    public class PersonasController : Controller
    {
        public IActionResult Index()
        {
            List<Persona> personas = PersonasRepositorio.GetPersonas();


            return View(personas);

            //Ejemplos de Return
            //return Json(personas);
            //return Json(PersonasRepositorio.GetPersonaEjemplo());
            //return StatusCode(200);
            //return Redirect("https://www.google.com");            
            //return RedirectToAction("Privacy","Home");
            //return RedirectToRoute("MiRuta");
            //return RedirectToAction("AddPersona");
        }


        [HttpGet]
        public IActionResult AddPersona()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPersona(string nombre, string apellido , int edad)
        {
            Persona personaCreada = new Persona() { Nombre = nombre, Apellido = apellido, Edad = edad};
            personaCreada.Nombre = nombre;
            personaCreada.Apellido = "Stark";
            personaCreada.Edad = edad;
            
            //Persistir este objeto.

            return View(personaCreada);
        }
    }
}