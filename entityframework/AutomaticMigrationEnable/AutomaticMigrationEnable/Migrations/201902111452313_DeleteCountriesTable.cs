namespace AutomaticMigrationEnable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCountriesTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teams", "Country_Id", "dbo.Countries");
            DropIndex("dbo.Teams", new[] { "Country_Id" });
            DropColumn("dbo.Teams", "Country_Id");
            CreateTable(
                "dbo._Countries",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Ad = c.String(),
                })
                .PrimaryKey(t => t.Id);
            Sql("Insert Into _Countries (Ad) select Ad from Countries");
            DropTable("dbo.Countries");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Teams", "Country_Id", c => c.Int());
            CreateIndex("dbo.Teams", "Country_Id");
            AddForeignKey("dbo.Teams", "Country_Id", "dbo.Countries", "Id");
            DropTable("dbo._Countries");
        }
    }
}
