namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusToAttendance : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendances", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attendances", "Status");
        }
    }
}
