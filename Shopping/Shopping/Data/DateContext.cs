using Microsoft.EntityFrameworkCore;
using Shopping.Date.Entities;

namespace Shopping.Data
{
    public class DataContext : DbContext
    {
        //Crear constructor para realizar conexion con la base de datos ctor tab tab
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
            
        }
        //Realizar conexiones de Paises
        public DbSet<Country> countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
        }
    }
}
