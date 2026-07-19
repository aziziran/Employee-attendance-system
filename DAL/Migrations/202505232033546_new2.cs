namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        EntryTime = c.DateTime(),
                        ExitTime = c.DateTime(),
                        IsMission = c.Boolean(nullable: false),
                        IsDelay = c.Boolean(nullable: false),
                        IsEarlyLeave = c.Boolean(nullable: false),
                        DailyLeaveHours = c.Int(nullable: false),
                        HourlyLeaveMinutes = c.Int(nullable: false),
                        OvertimeMinutes = c.Int(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DailyLeaves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        LeaveDate = c.DateTime(nullable: false),
                        Reason = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        FatherName = c.String(),
                        NationalCode = c.String(nullable: false),
                        Picture = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Delays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.EarlyLeaves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.EntryExits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        EntryTime = c.DateTime(nullable: false),
                        ExitTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.HourlyLeaves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(),
                        Reason = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Missions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.OverTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Username = c.String(),
                        PasswordHash = c.String(),
                        Role = c.String(),
                        RegisterDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OverTimes", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Missions", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.HourlyLeaves", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.EntryExits", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.EarlyLeaves", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Delays", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.DailyLeaves", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.OverTimes", new[] { "EmployeeId" });
            DropIndex("dbo.Missions", new[] { "EmployeeId" });
            DropIndex("dbo.HourlyLeaves", new[] { "EmployeeId" });
            DropIndex("dbo.EntryExits", new[] { "EmployeeId" });
            DropIndex("dbo.EarlyLeaves", new[] { "EmployeeId" });
            DropIndex("dbo.Delays", new[] { "EmployeeId" });
            DropIndex("dbo.DailyLeaves", new[] { "EmployeeId" });
            DropTable("dbo.Users");
            DropTable("dbo.OverTimes");
            DropTable("dbo.Missions");
            DropTable("dbo.HourlyLeaves");
            DropTable("dbo.EntryExits");
            DropTable("dbo.EarlyLeaves");
            DropTable("dbo.Delays");
            DropTable("dbo.Employees");
            DropTable("dbo.DailyLeaves");
            DropTable("dbo.Attendances");
        }
    }
}
