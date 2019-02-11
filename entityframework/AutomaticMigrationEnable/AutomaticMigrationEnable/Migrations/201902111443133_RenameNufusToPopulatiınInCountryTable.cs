namespace AutomaticMigrationEnable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameNufusToPopulatiınInCountryTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Countries", "Population", c => c.Int(nullable: false));
            Sql("Update Countries set Population=Nufus");
            DropColumn("dbo.Countries", "Nufus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Countries", "Nufus", c => c.Int(nullable: false));
            Sql("Update Countries set Nufus=Population");
            DropColumn("dbo.Countries", "Population");
        }
    }
}
