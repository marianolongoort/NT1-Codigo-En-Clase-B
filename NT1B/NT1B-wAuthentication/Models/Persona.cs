using System;

namespace NT1B_wAuthentication.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private int edad;

        public bool Casado { get; set; } = true;


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