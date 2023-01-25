using ApiVentas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiVentas.Data
{
    public class dbContext : DbContext

    {
        // Constructor
        public dbContext(DbContextOptions<dbContext> options) : base(options) { }

        // Propiedades DbSet para cada tabla
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<ItemVenta> ItemVentas { get; set; }
        public DbSet<Producto> Productos { get; set; }

    }
}
