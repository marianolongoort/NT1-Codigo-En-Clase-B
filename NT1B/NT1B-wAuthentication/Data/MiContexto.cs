using Microsoft.EntityFrameworkCore;
using NT1B_wAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT1B_wAuthentication.Data
{
    public class MiContexto : DbContext
    {
        public MiContexto(DbContextOptions<MiContexto> options) : base(options)
        {
            
        }

        public DbSet<Persona> Personas { get; set; }
    }
}
