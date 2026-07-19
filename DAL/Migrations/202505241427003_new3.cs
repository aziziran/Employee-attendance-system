namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DailyLeaves", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Delays", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.EarlyLeaves", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.EntryExits", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.HourlyLeaves", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Missions", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.OverTimes", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.DailyLeaves", new[] { "EmployeeId" });
            DropIndex("dbo.Delays", new[] { "EmployeeId" });
            DropIndex("dbo.EarlyLeaves", new[] { "EmployeeId" });
            DropIndex("dbo.EntryExits", new[] { "EmployeeId" });
            DropIndex("dbo.HourlyLeaves", new[] { "EmployeeId" });
            DropIndex("dbo.Missions", new[] { "EmployeeId" });
            DropIndex("dbo.OverTimes", new[] { "EmployeeId" });
            DropTable("dbo.Attendances");
            DropTable("dbo.DailyLeaves");
            DropTable("dbo.Delays");
            DropTable("dbo.EarlyLeaves");
            DropTable("dbo.EntryExits");
            DropTable("dbo.HourlyLeaves");
            DropTable("dbo.Missions");
            DropTable("dbo.OverTimes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OverTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EntryExits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        EntryTime = c.DateTime(nullable: false),
                        ExitTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EarlyLeaves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
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
                .PrimaryKey(t => t.Id);
            
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
            
            CreateIndex("dbo.OverTimes", "EmployeeId");
            CreateIndex("dbo.Missions", "EmployeeId");
            CreateIndex("dbo.HourlyLeaves", "EmployeeId");
            CreateIndex("dbo.EntryExits", "EmployeeId");
            CreateIndex("dbo.EarlyLeaves", "EmployeeId");
            CreateIndex("dbo.Delays", "EmployeeId");
            CreateIndex("dbo.DailyLeaves", "EmployeeId");
            AddForeignKey("dbo.OverTimes", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Missions", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.HourlyLeaves", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.EntryExits", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.EarlyLeaves", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Delays", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DailyLeaves", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
    }
}
