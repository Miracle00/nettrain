namespace AutomaticMigrationEnable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletePopulationColumnInCountry : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Countries", "Population");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Countries", "Population", c => c.Int(nullable: false));
        }
    }
}
