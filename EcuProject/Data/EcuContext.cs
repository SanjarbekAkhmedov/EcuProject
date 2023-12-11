using Microsoft.EntityFrameworkCore;
using EcuProject.Model;

namespace EcuProject.Data
{
    public class EcuContext : DbContext
    {
        string connectionString = "Server=b29838ev.beget.tech;Database=b29838ev_ecubase;User=b29838ev_ecubase;Password=8T&DRs2f;Connection Timeout=1800;default command timeout=1800";

        public EcuContext(DbContextOptions<EcuContext> options)
            : base(options)
        {
        }

        public DbSet<AppCarmaker> AppCarmaker { get; set; } = default!;
        public DbSet<AppEcu> AppEcu { get; set; } = default!;
        public DbSet<AppEcuType> AppEcuType { get; set; } = default!;
        public DbSet<AppEcuProducer> AppEcuProducer { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
