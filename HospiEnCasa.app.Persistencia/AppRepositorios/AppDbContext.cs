using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HospiEnCasa.app.Dominio;

namespace HospiEnCasa.app.Persistencia
{
    public class AppDbContext : DbContext
    {
        //se crean el mapeo a las tablas de la base de datos
        public DbSet<Persona>? Personas { get; set; }

        //metodo para genera la sesion en base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=HospiEnCasaData; Trusted_Connection=true;");
            }
        }
    }
}