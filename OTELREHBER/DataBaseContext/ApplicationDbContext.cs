using Microsoft.EntityFrameworkCore;
using OTELREHBER.Entitiy;

namespace OTELREHBER.DataBaseContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) :base(options)
        {
        }
        public DbSet<Otel> Otels { get; set; }
        public DbSet<Oteliletisim> Oteliletisims { get; set; }
    }
}
