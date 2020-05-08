using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NT1B_wAuthentication.Data;
using NT1B_wAuthentication.Models;
using NT1B_wAuthentication.Servicios;

namespace NT1B_wAuthentication.Controllers
{
    public class PersonasController : Controller
    {
        private readonly IRepositorio _repositorio;
        private readonly MiContexto _contexto;

        public PersonasController(IRepositorio repo,MiContexto context)
        {
            _repositorio = repo;
            _contexto = context;
        }



        public IActionResult Index()
        {
            List<Persona> personas = _repositorio.GetPersonas();
            _repositorio.GetTelefonos();
            _repositorio.GetDirecciones();


            Persona per1 = new Persona();
            per1.Apellido = "Longo";
            per1.Nombre = "Mariano";
            per1.Casado = true;
            per1.Edad = 42;

            //_contexto.Personas.Add(per1);

            //var personasABorrar = _contexto.Personas.ToList();            
            //_contexto.Personas.RemoveRange(personasABorrar);
            _contexto.SaveChanges();

            var personasEnBaseDeDatos  = _contexto.Personas.ToList() ;



            return View(personasEnBaseDeDatos);
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
            //Ejemplo, para refrescar los datos de la tabla personas, en memoria.
            //_contexto.Personas.RemoveRange(_contexto.Personas.ToList());
            //_contexto.SaveChanges();

            List<int> numeros = new List<int>() { 1,3,2,5,-3,9,-8,10};
            
            var numerosMayores = numeros.Where(num => num > 0).OrderByDescending(x => x);

            List<Persona> personas = _repositorio.GetPersonas();

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