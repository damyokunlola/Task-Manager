namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VS1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ScheduleSet", "Password_Email", "dbo.tblRegister");
            DropForeignKey("dbo.ScheduleSet", "Username_Email", "dbo.tblRegister");
            DropIndex("dbo.ScheduleSet", new[] { "Password_Email" });
            DropIndex("dbo.ScheduleSet", new[] { "Username_Email" });
            AddColumn("dbo.ScheduleSet", "Description", c => c.String(nullable: false));
            AddColumn("dbo.ScheduleSet", "Email", c => c.String(nullable: false));
            AddColumn("dbo.ScheduleSet", "Username", c => c.String(nullable: false));
            AddColumn("dbo.ScheduleSet", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.ScheduleSet", "Categories", c => c.String(nullable: false));
            AlterColumn("dbo.ScheduleSet", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ScheduleSet", "Location", c => c.String(nullable: false));
            DropColumn("dbo.ScheduleSet", "SchName");
            DropColumn("dbo.ScheduleSet", "Password_Email");
            DropColumn("dbo.ScheduleSet", "Username_Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ScheduleSet", "Username_Email", c => c.String(maxLength: 128));
            AddColumn("dbo.ScheduleSet", "Password_Email", c => c.String(maxLength: 128));
            AddColumn("dbo.ScheduleSet", "SchName", c => c.String());
            AlterColumn("dbo.ScheduleSet", "Location", c => c.String());
            AlterColumn("dbo.ScheduleSet", "Date", c => c.DateTime());
            AlterColumn("dbo.ScheduleSet", "Categories", c => c.String());
            DropColumn("dbo.ScheduleSet", "Password");
            DropColumn("dbo.ScheduleSet", "Username");
            DropColumn("dbo.ScheduleSet", "Email");
            DropColumn("dbo.ScheduleSet", "Description");
            CreateIndex("dbo.ScheduleSet", "Username_Email");
            CreateIndex("dbo.ScheduleSet", "Password_Email");
            AddForeignKey("dbo.ScheduleSet", "Username_Email", "dbo.tblRegister", "Email");
            AddForeignKey("dbo.ScheduleSet", "Password_Email", "dbo.tblRegister", "Email");
        }
    }
}
