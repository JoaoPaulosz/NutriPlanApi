using Microsoft.EntityFrameworkCore;
using NutriPlanApi.Models;

namespace NutriPlanApi.Data
{
    public class NutriPlanContext : DbContext
    {
        public NutriPlanContext(DbContextOptions<NutriPlanContext> opts) : base(opts) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alimento>()
                .HasOne(alimento => alimento.Usuario)
                .WithMany(usuario => usuario.Alimentos)
                .HasForeignKey(alimento => alimento.usuario_id);
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Alimento> alimento { get; set; }
    }
}
