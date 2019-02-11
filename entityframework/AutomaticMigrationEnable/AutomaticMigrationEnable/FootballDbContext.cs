using System.Data.Entity;

namespace AutomaticMigrationEnable
{
    public class FootballDbContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerAddress> Addresses { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public FootballDbContext():base("FootballDbConStr")
        {

        }
    }
}
