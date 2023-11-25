using Microsoft.EntityFrameworkCore;
using NutriPlanApi.Models;

namespace NutriPlanApi.Data
{
    public class NutriPlanContext : DbContext
    {
        public NutriPlanContext(DbContextOptions<NutriPlanContext> opts) : base(opts) { }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
