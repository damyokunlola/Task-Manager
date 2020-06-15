namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vs1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ScheduleSet", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ScheduleSet", "Status");
        }
    }
}
