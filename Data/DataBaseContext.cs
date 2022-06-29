using Microsoft.EntityFrameworkCore;

namespace zktco_access.Data
{
    public class DataBaseContext :DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {

        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Controlador> Controlador { get; set; }
        public DbSet<Proyecto> Proyecto { get; set; }
    }
}
