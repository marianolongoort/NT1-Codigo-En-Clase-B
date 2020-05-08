using System;
using System.ComponentModel.DataAnnotations;

namespace NT1B_wAuthentication.Models
{
    public class Persona
    {
        public int PersonaId { get; set; }

        public string Nombre { get; set; }

        [MaxLength(50)]
        public string Apellido { get; set; }

        public int DNI { get; set; }

        private int edad;

        public bool Casado { get; set; } = true;

        public Direccion Direccion { get; set; }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (value > 0) { edad = value; } else { throw new Exception("No puede ser la edad menor que 0"); };
            }
        }
                
    }
}