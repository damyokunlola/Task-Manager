namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LatestVs : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ScheduleSet", "Username");
            DropColumn("dbo.ScheduleSet", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ScheduleSet", "Password", c => c.String(nullable: false));
            AddColumn("dbo.ScheduleSet", "Username", c => c.String(nullable: false));
        }
    }
}
