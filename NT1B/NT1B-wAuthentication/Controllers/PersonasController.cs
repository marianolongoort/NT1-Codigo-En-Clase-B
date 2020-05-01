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

        public IActionResult TestPasajeDatos()
        {
            List<int> numeros = new List<int>() { 1,3,2,5,-3,9,-8,10};
            
            var numerosMayores = numeros.Where(num => num > 0).OrderByDescending(x => x);

            List<Persona> personas = PersonasRepositorio.GetPersonas();

            var personasLinq = personas.Where(p => p.Edad > 40).OrderBy(a => a.Edad).ThenByDescending(a => a.Apellido);

            ViewBag.LasPersonas = personasLinq;
            ViewBag.LoqueQuieras = "Te paso un String";
            ViewBag.UnInt = 4;

            return View(numerosMayores);
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