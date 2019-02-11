using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticMigrationEnable
{
    public class Country
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
