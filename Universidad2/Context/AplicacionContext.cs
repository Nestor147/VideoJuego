using Microsoft.EntityFrameworkCore;
using Universidad2.Models;

namespace Universidad2.Context
{
    public class AplicacionContext:DbContext
    {
        public AplicacionContext(DbContextOptions<AplicacionContext> options)
        :base(options){ }
        public DbSet<Email> Email { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<VideoJuego> VideoJuego { get; set; }
        public DbSet<Autos> Autos { get; set; }
    }
}
