using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Persistences
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }
        public DbSet<Empleado> Empleado { get; set; }
    }
}
