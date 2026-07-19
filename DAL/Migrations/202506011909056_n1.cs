namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class n1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendances", "IsHourlyLeaveExit", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attendances", "IsHourlyLeaveExit");
        }
    }
}
