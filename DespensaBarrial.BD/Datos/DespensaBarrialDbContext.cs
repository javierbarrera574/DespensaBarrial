using DespensaBarrial.BD.Datos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace DespensaBarrial.BD.Datos
{
    public class DespensaBarrialDbContext : DbContext
    {
        public DespensaBarrialDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Categorias> Categorias { get; set; }

        public DbSet<Productos> Productos { get; set; }

        public DbSet<Proveedores> Proveedores { get; set; }


    }
}
