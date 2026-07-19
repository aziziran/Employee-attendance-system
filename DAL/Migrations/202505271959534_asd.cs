namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendances", "Duration", c => c.Time(precision: 7));
            AddColumn("dbo.Attendances", "Type", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attendances", "Type");
            DropColumn("dbo.Attendances", "Duration");
        }
    }
}
