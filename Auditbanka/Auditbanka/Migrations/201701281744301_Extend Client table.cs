namespace Auditbanka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtendClienttable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Experience", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "Osvita", c => c.String());
            AddColumn("dbo.Clients", "IsMarried", c => c.String());
            AddColumn("dbo.Clients", "Children", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "HasDeposit", c => c.String());
            AddColumn("dbo.Clients", "Statistica", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "Statistica");
            DropColumn("dbo.Clients", "HasDeposit");
            DropColumn("dbo.Clients", "Children");
            DropColumn("dbo.Clients", "IsMarried");
            DropColumn("dbo.Clients", "Osvita");
            DropColumn("dbo.Clients", "Experience");
        }
    }
}
