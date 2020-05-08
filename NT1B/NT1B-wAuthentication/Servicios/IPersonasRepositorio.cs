using NT1B_wAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT1B_wAuthentication.Servicios
{
    public interface IRepositorio
    {
        List<Persona> GetPersonas();
        Persona GetPersonaEjemplo();

        List<Direccion> GetDirecciones();
        List<string> GetTelefonos();

    }
}
