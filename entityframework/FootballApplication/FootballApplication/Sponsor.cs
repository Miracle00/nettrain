using System.Collections.Generic;

namespace FootballApplication
{
    public class Sponsor
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
