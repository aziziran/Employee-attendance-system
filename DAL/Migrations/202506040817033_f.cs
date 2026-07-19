namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Attendances", "RegisterDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Attendances", "RegisterDate", c => c.DateTime(nullable: false));
        }
    }
}
