using System;
using System.Collections.Generic;
using System.Text;

namespace NT1B_Console.Models
{
    public class Persona
    {
        #region Constructores
        public Persona()
        {
                
        }

        public Persona(int id, string nombre, string apellido)
        {
            this.PersonaId = id;
            this.SetNombre(nombre);
            this.Apellido = apellido;
            this.Direccion = new Direccion();
        }
        
        public Persona(int id, string nombre, string apellido, Direccion direccion)
        {
            this.PersonaId = id;
            this.SetNombre(nombre);
            this.Apellido = apellido;
            this.Direccion = direccion;
        }

        #endregion

        #region Propiedades
        private int id;
        public int PersonaId { get => id; set => id = value; }

        private string nombre;
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetNombre()
        {
            return this.nombre;
        }

        public string Apellido { get; set; }

        //Relacion uno a uno
        public Mascota Mascota { get; set; }
                
        public Direccion Direccion { get; set; }

        //Uno a Muchos
        public ICollection<Telefono> Telefonos { get; set; }

        //Muchos a Muchos, generamos una nueva Entidad para la relación
        public ICollection<PersonaDireccion> Direcciones { get; set; }

        #endregion
    }
}
