namespace Auditbanka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Audittable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Audits",
                c => new
                    {
                        AuditId = c.Int(nullable: false, identity: true),
                        DateofAudit = c.DateTime(nullable: false),
                        Result = c.String(),
                        DogovirId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AuditId)
                .ForeignKey("dbo.Dogovirs", t => t.DogovirId, cascadeDelete: true)
                .Index(t => t.DogovirId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Audits", "DogovirId", "dbo.Dogovirs");
            DropIndex("dbo.Audits", new[] { "DogovirId" });
            DropTable("dbo.Audits");
        }
    }
}
