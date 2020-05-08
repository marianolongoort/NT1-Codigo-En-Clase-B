using NT1B_wAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT1B_wAuthentication.Servicios
{
    public class RepositorioEnMemoria : IRepositorio
    {
        public List<Persona> GetPersonas()
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona()
            {
                Nombre = "Mariano",
                Apellido = "Longo",
                Edad = 60
            });

            personas.Add(new Persona()
            {
                Nombre = "Pablo",
                Apellido = "Marmol",
                Edad = 50
            }
            );

            personas.Add(new Persona()
            {
                Nombre = "Pedro",
                Apellido = "Picapiedra",
                Edad = 50
            });

            return personas;
        }

        public Persona GetPersonaEjemplo()
        {
            return new Persona()
            {
                Nombre = "Mariano",
                Apellido = "Longo",
                Edad = 42
            };
        }

        public List<Direccion> GetDirecciones()
        {
            throw new NotImplementedException();
        }

        public List<string> GetTelefonos()
        {
            throw new NotImplementedException();
        }
    }
}
