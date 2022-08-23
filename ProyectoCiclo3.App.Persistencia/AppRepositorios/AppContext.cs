using Microsoft.EntityFrameworkCore;
using ProyectoCiclo3.App.Dominio;

namespace ProyectoCiclo3.App.Persistencia{
    public class AppContext: DbContext{
        public DbSet<Aeropuertos> Aeropuertos {get; set;}
        public DbSet<Rutas> Rutas {get; set;}
        public Dbset<Aviones> Aviones {get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder){
            if(!OptionsBuilder.IsConfigured){
                OptionsBuilder.UseSqlServer()
            }
        }
    }
}