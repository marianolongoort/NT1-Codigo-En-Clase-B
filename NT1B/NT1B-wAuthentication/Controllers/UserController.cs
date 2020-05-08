using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NT1B_wAuthentication.Models;
using NT1B_wAuthentication.Servicios;

namespace NT1B_wAuthentication.Controllers
{
    public class UserController : Controller
    {
        private readonly IRepositorio _repositorio;

        public UserController(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public IActionResult Index()
        {
            _repositorio.GetPersonas();
            _repositorio.GetDirecciones();

            return View();
        }

        public IActionResult Add(string nombre = "Pedro", string apellido = "Picapiedra")
        {
            ////todo lo que necesite.
            Persona elusuario = new Persona();
            elusuario.Nombre = nombre;
            elusuario.Apellido = apellido;

            nombre = "Mariano";

            ViewBag.MiNombre = nombre;
            ViewData["Nom"] = nombre;
            TempData["Nom"] = nombre;

            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona() { Nombre = "Pablo", Apellido = "Marmol" });
            personas.Add(new Persona() { Nombre = "Tony", Apellido = "Stark" });
            personas.Add(new Persona() { Nombre = "El Topo", Apellido = "Gigo" });








            return View(elusuario);
            //Para ver respuestas.
            //return Json(elusuario);
            //return Json(personas);
            //return Redirect("http://google.com");
            //return RedirectToAction("Privacy","Home");
            //return RedirectToRoute("MiRuta);
            //return new HttpStatusCodeResult(301,"HOLA!!!"); //Para .net Framework con MVC
            //return Redirect("https://www.yahoo.com"); Ok, NotFound, etc.
            //return StatusCode(200);
            //return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status200OK);            
        }



        //
    }
}