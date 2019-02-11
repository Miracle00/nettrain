namespace FootballApplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FootballApplication.FootballContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //True ise kontrol entityde, false ise kontrol kullan�c�da
        }

        protected override void Seed(FootballApplication.FootballContext context)
        {
            //Add Or Update Komutunu kullan�rken Id vermek zorunday�z kay�t varsa g�ncelleyecek
            //context.Teams.AddOrUpdate
            //    (
            //        new Team { Id = 1, Ad = "Galatasaray", KurulusYili = 1905 },
            //        new Team { Id = 2, Ad = "Fenerbah�e", KurulusYili = 1907 },
            //        new Team { Id = 3, Ad = "Trabzon", KurulusYili = 1967 }
            //    );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
