namespace Auditbanka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Password");
        }
    }
}
