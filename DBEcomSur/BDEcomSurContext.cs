using Microsoft.EntityFrameworkCore;

namespace DBEcomSur
{
    public class BDEcomSurContext:DbContext

    {
        public BDEcomSurContext(DbContextOptions<BDEcomSurContext>options)
            :base(options) 
        {

        }
        public DbSet<BDProducto> BDProductos { get; set; }
        public DbSet<BDUsuario> BDUsuarios { get; set; }
        public DbSet<BDVenta> BDVentas { get; set;}

       
    }
}