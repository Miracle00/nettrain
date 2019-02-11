using System.ComponentModel.DataAnnotations.Schema;

namespace AutomaticMigrationEnable
{
    public class PlayerAddress
    {
        [ForeignKey("Player")]
        public int PlayerAddressId { get; set; }
        public string City { get; set; }
        public int Street { get; set; }
        public int PostCode { get; set; }
        public Player Player { get; set; }
    }
}
