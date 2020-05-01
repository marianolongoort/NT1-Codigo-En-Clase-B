using NT1B_wAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT1B_wAuthentication.Servicios
{
    public static class PersonasRepositorio
    {
        public static List<Persona> GetPersonas()
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona()
            {
                Nombre = "Mariano",
                Apellido = "Longo",
                Edad = 42
            });

            personas.Add(new Persona()
            {
                Nombre = "Pablo",
                Apellido = "Marmol",
                Edad = 999
            }
            );

            personas.Add(new Persona()
            {
                Nombre = "Pedro",
                Apellido = "Picapiedra",
                Edad = 1200
            });

            return personas;
        }

        public static Persona GetPersonaEjemplo()
        {
            return new Persona()
            {
                Nombre = "Mariano",
                Apellido = "Longo",
                Edad = 42
            };
        }
    }
}
