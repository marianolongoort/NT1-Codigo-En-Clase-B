using NT1B_Console.Models;
using System;

namespace NT1B_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡¡¡Hola Curso!!!");

            #region Constructor por defecto
            Persona per1 = new Persona();

            MostrarEstadoInterno(per1);

            per1.PersonaId = 1;
            per1.SetNombre("Mariano");
            per1.Apellido = "Longo";            

            MostrarEstadoInterno(per1);

            #endregion
            Pausa();

            #region Constructor parametrizado 1
            Persona per2 = new Persona(2, "Pedro", "Picapiedra");
            MostrarEstadoInterno(per2);
            per2.Direccion.Calle = "Roca Buena";
            per2.Direccion.Numero = 25;
            per2.Direccion.CodigoPostal = 1111;
            MostrarEstadoInterno(per2);

            #endregion
            Pausa();

            #region Constructor parametrizado 2
            Direccion direcPM = new Direccion();
            direcPM.Calle = "Caverna oscura";
            direcPM.Numero = 666;
            direcPM.CodigoPostal = 2323;
            direcPM.NombreDelEncargado = "Pedro";

            Persona per3 = new Persona(3333333, "Pablo", "Marmol",direcPM);

            per3.Direccion.Numero = 777;
            
            direcPM.Numero = 888;

            MostrarEstadoInterno(per3);

            #endregion
            
        }

        private static void MostrarEstadoInterno(Persona persona)
        {
            ImprimirEncabezado("Mostrando estado interno de la persona " + persona.PersonaId);
            ImprimirLinea("Id = " + persona.PersonaId);
            ImprimirLinea("Nombre = " + persona.GetNombre());
            ImprimirLinea("Apellido = " + persona.Apellido);            
            //ImprimirLinea("Direccion = " + persona.Direccion);

            //Para poder acceder a los atributos de dirección y que no se presente una excepción, se debe disponer del objeto ya instanciado.
            if (persona.Direccion != null)
            {
                //A Modo de ejemplo, en este caso, mejoro el comportamiento, y en lugar de mostrar atributo por atributo de la persona
                //Delego en Dirección, que me pase el estado Interno como un string, de la forma que lo quiero mostrar.
                //De esta forma, evito tener que conocer en el programa como está conformado el objeto.
                ImprimirLinea(persona.Direccion.GetEstadoInternoEnLineas());                  
            }
            else
            {
                ImprimirLinea("No hay una dirección definida");
            }            
        }

        private static void ImprimirEncabezado(string msg)
        {            
            if(msg == null)
            {
                msg = "Mostrando encabezado por defecto";
            }

            ImprimirLinea(GenerarBarra(msg.Length,"#"));            
            ImprimirLinea(msg);
            ImprimirLinea(GenerarBarra(msg.Length,"-"));
        }

        private static string GenerarBarra(int largo,string caracter)
        {
            string barra = String.Empty;
            for(int i = 0; i < largo; i++)
            {
                barra += caracter;
            }
            return barra;
        }

        private static void ImprimirLinea(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
        private static void ImprimirEnLinea(string mensaje)
        {
            Console.Write(mensaje);
        }
        private static void Pausa()
        {
            Console.ReadKey();
        }
    }
}
