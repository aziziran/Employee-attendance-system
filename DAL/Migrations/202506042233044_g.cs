namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class g : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendances", "OvertimeEntryId", c => c.Int());
            CreateIndex("dbo.Attendances", "OvertimeEntryId");
            AddForeignKey("dbo.Attendances", "OvertimeEntryId", "dbo.Attendances", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "OvertimeEntryId", "dbo.Attendances");
            DropIndex("dbo.Attendances", new[] { "OvertimeEntryId" });
            DropColumn("dbo.Attendances", "OvertimeEntryId");
        }
    }
}
