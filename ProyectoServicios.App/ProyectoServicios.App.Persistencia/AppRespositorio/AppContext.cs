
using Microsoft.EntityFrameworkCore;
using ProyectoServicios.App.Dominio.Entidades;

namespace ProyectoServicios.App.Persistencia
{
    public class AppContext:DbContext
    {
      public DbSet <Personas> Personas{get;set;} 

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BDProyecto Servicios");
        }
    }
    }

}