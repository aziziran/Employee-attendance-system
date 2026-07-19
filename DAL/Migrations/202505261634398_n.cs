namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class n : DbMigration
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
                        Time = c.DateTime(nullable: false),
                        Type = c.Int(nullable: false),
                        Delay = c.Time(precision: 7),
                        EarlyLeave = c.Time(precision: 7),
                        Overtime = c.Time(precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SystemTimeLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastValidDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SystemTimeLogs");
            DropTable("dbo.Attendances");
        }
    }
}
