// *******************************************
using Microsoft.EntityFrameworkCore;
using SeguridadWeb.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SeguridadWeb.AccesoADatos
{
    public class BDContexto : DbContext
    {
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = Seguridadwebdb; Integrated Security = True; Encrypt = False; Trust Server Certificate = True");
        }
    }
}