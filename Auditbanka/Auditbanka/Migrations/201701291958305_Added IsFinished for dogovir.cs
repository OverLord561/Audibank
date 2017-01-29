namespace Auditbanka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIsFinishedfordogovir : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dogovirs", "IsPayed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Dogovirs", "IsPayed");
        }
    }
}
