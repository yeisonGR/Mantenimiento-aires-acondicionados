using Microsoft.EntityFrameworkCore;
using JCalentadores.App.Dominio;

namespace JCalentadores.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Citas> Cita {get;set;}
        public DbSet<CitasServicios> CitaServicio {get;set;}
        public DbSet<Servicios> Servicio {get;set;}
        public DbSet<Usuarios> usuarios {get;set;}
        public DbSet<Historial> HistorialCitas {get;set;}
        
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {

                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = JCalentadoresData1");

            }

        }

    }

}