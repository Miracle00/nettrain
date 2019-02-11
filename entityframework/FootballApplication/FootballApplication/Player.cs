using System;

namespace FootballApplication
{
    public class Player
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Team Team { get; set; }
        public PlayerAddress Address { get; set; }
    }
}
