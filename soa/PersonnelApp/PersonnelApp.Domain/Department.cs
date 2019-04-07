using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Domain
{
    public class Department:BaseEntity
    {
        public Department()
        {
            Personnels = new List<Personnel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Personnel> Personnels { get; set; }
    }
}
