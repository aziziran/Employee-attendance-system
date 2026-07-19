namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendances", "EntryTime", c => c.DateTime());
            AddColumn("dbo.Attendances", "ExitTime", c => c.DateTime());
            AddColumn("dbo.Attendances", "Earliness", c => c.Time(nullable: false, precision: 7));
            AddColumn("dbo.Attendances", "HasDailyLeave", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Attendances", "Delay", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.Attendances", "Overtime", c => c.Time(nullable: false, precision: 7));
            CreateIndex("dbo.Attendances", "EmployeeId");
            AddForeignKey("dbo.Attendances", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            DropColumn("dbo.Attendances", "Time");
            DropColumn("dbo.Attendances", "Type");
            DropColumn("dbo.Attendances", "EarlyLeave");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Attendances", "EarlyLeave", c => c.Time(precision: 7));
            AddColumn("dbo.Attendances", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.Attendances", "Time", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.Attendances", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Attendances", new[] { "EmployeeId" });
            AlterColumn("dbo.Attendances", "Overtime", c => c.Time(precision: 7));
            AlterColumn("dbo.Attendances", "Delay", c => c.Time(precision: 7));
            DropColumn("dbo.Attendances", "HasDailyLeave");
            DropColumn("dbo.Attendances", "Earliness");
            DropColumn("dbo.Attendances", "ExitTime");
            DropColumn("dbo.Attendances", "EntryTime");
        }
    }
}
