using AspNetWebApiNombres.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetWebApiNombres.Context
{

    public class NombreContext : DbContext
    {
        public NombreContext(DbContextOptions options) 
            : base(options)
        {

        }
        public DbSet<Nombre> Nombres { get; set; } = null;
    }
}
