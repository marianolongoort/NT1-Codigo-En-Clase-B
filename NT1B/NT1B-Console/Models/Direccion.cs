using System;

namespace NT1B_Console.Models
{
    public class Direccion
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public int Piso { get; set; }
        public string Departamento { get; set; }
        public int CodigoPostal { get; set; }

        public string GetEstadoInternoEnLineas()
        {
            //Sin Id, porque no es de mi interes
            return                
                "Calle: " + this.Calle + Environment.NewLine +
                "Numero: " + this.Numero + Environment.NewLine +
                "Piso: " + this.Piso + Environment.NewLine +
                "Departamento: " + this.Departamento + Environment.NewLine +
                "Codigo Postal: " + this.CodigoPostal + Environment.NewLine;
        }

    }
}