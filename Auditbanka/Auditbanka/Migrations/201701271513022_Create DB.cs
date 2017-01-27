namespace Auditbanka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        AdressId = c.Int(nullable: false),
                        Country = c.String(),
                        Region = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        Building = c.Int(nullable: false),
                        BuildingNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AdressId)
                .ForeignKey("dbo.Clients", t => t.AdressId)
                .Index(t => t.AdressId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        SecondName = c.String(),
                        Name = c.String(),
                        SurName = c.String(),
                        PlaceOfJob = c.String(),
                        Position = c.String(),
                        Telephone = c.String(),
                        AmountOfIncome = c.Double(nullable: false),
                        Passport = c.String(),
                        DateOfPassport = c.DateTime(nullable: false),
                        PassportIssuedBy = c.String(),
                        Identification = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Sex = c.String(),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.Dogovirs",
                c => new
                    {
                        DogovirId = c.Int(nullable: false, identity: true),
                        TypeOfCredit = c.String(),
                        AmountOfCredit = c.Double(nullable: false),
                        Currency = c.String(),
                        Rate = c.Double(nullable: false),
                        DateOfGetting = c.DateTime(nullable: false),
                        Termin = c.Int(nullable: false),
                        Target = c.String(),
                        EmployeeId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DogovirId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SecondName = c.String(),
                        Surname = c.String(),
                        PersonalNumber = c.Int(nullable: false),
                        Position = c.String(),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                        LegalAdress = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Providings",
                c => new
                    {
                        ProvidingId = c.Int(nullable: false, identity: true),
                        TypeOfProviding = c.String(),
                        Total = c.Double(nullable: false),
                        DogovirId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProvidingId)
                .ForeignKey("dbo.Dogovirs", t => t.DogovirId, cascadeDelete: true)
                .Index(t => t.DogovirId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Adresses", "AdressId", "dbo.Clients");
            DropForeignKey("dbo.Providings", "DogovirId", "dbo.Dogovirs");
            DropForeignKey("dbo.Dogovirs", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Dogovirs", "ClientId", "dbo.Clients");
            DropIndex("dbo.Providings", new[] { "DogovirId" });
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropIndex("dbo.Dogovirs", new[] { "ClientId" });
            DropIndex("dbo.Dogovirs", new[] { "EmployeeId" });
            DropIndex("dbo.Adresses", new[] { "AdressId" });
            DropTable("dbo.Providings");
            DropTable("dbo.Departments");
            DropTable("dbo.Employees");
            DropTable("dbo.Dogovirs");
            DropTable("dbo.Clients");
            DropTable("dbo.Adresses");
        }
    }
}
