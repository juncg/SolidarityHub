using Microsoft.EntityFrameworkCore;
using PRUEBAS.Models;

namespace PRUEBAS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Afectado> Afectados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=Tests;Username=postgres;Password=JPRA");
            }
        }
    }
}