namespace Auditbanka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tableofsplata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Splatas",
                c => new
                    {
                        SplataId = c.Int(nullable: false, identity: true),
                        NumberOfSplata = c.Int(nullable: false),
                        DateOfSplata = c.DateTime(nullable: false),
                        SumOfSplata = c.Double(nullable: false),
                        TotalSplata = c.Double(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SplataId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Splatas", "ClientId", "dbo.Clients");
            DropIndex("dbo.Splatas", new[] { "ClientId" });
            DropTable("dbo.Splatas");
        }
    }
}
