using System;
using System.Collections.Generic;
using System.Text;

namespace NT1B_Console.Models
{
    public class Persona
    {
        public Persona()
        {
                
        }

        public Persona(int id, string nombre, string apellido)
        {
            this.Id = id;
            this.SetNombre(nombre);
            this.Apellido = apellido;
            this.Direccion = new Direccion();
        }
        public Persona(int id, string nombre, string apellido, Direccion direccion)
        {
            this.Id = id;
            this.SetNombre(nombre);
            this.Apellido = apellido;
            this.Direccion = direccion;
        }

        #region Propiedades
        private int id;
        public int Id { get => id; set => id = value; }

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

        public Direccion Direccion { get; set; }

        #endregion
    }
}
