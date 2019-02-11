namespace AutomaticMigrationEnable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameAdToNameInTeamsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Name", c => c.String());
            Sql("Update Teams set Name=Ad");
            DropColumn("dbo.Teams", "Ad");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "Ad", c => c.String());
            Sql("Update Teams set Ad=Name");
            DropColumn("dbo.Teams", "Name");
        }
    }
}
