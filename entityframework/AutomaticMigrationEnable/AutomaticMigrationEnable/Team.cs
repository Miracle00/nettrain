using System.Collections.Generic;

namespace AutomaticMigrationEnable
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short Kurulusyili { get; set; }
        public ICollection<Player> Players { get; set; }
        public ICollection<Sponsor> Sponsors { get; set; }
    }
}
