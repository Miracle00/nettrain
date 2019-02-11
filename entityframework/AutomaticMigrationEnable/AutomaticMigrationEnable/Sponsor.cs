using System.Collections.Generic;

namespace AutomaticMigrationEnable
{
    public class Sponsor
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
