using NT1B_wAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT1B_wAuthentication.Servicios
{
    public class RepositorioSQL : IRepositorio
    {
        public List<Direccion> GetDirecciones()
        {
            return new List<Direccion>();
        }

        public Persona GetPersonaEjemplo()
        {
            //Pongo el codigo que necesito para devolver una persona
            return new Persona();
        }

        public List<Persona> GetPersonas()
        {
            //Pongo el codigo que necesito para devolver personas.
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona()
            {
                Nombre = "Marianooooooooo",
                Apellido = "Longoooooo",
                Edad = 99
            });

            

            return personas;
        }

        public List<string> GetTelefonos()
        {
            return new List<string>();
        }
    }
}
