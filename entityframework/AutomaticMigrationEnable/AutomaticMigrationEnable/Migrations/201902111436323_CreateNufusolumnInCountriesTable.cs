namespace AutomaticMigrationEnable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateNufusolumnInCountriesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Countries", "Nufus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Countries", "Nufus");
        }
    }
}
