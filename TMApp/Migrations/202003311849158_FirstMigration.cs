namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.tblSchedule", newName: "tblRegister");
            DropForeignKey("dbo.ScheduleSet", "Password_Id", "dbo.tblSchedule");
            DropForeignKey("dbo.ScheduleSet", "Username_Id", "dbo.tblSchedule");
            DropIndex("dbo.ScheduleSet", new[] { "Password_Id" });
            DropIndex("dbo.ScheduleSet", new[] { "Username_Id" });
            RenameColumn(table: "dbo.ScheduleSet", name: "Password_Id", newName: "Password_Username");
            RenameColumn(table: "dbo.ScheduleSet", name: "Username_Id", newName: "Username_Username");
            DropPrimaryKey("dbo.tblRegister");
            AlterColumn("dbo.tblRegister", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblRegister", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.tblRegister", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.tblRegister", "Username", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.tblRegister", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.ScheduleSet", "Password_Username", c => c.String(maxLength: 128));
            AlterColumn("dbo.ScheduleSet", "Username_Username", c => c.String(maxLength: 128));
            AlterColumn("dbo.tblLogin", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.tblLogin", "Password", c => c.String(nullable: false));
            AddPrimaryKey("dbo.tblRegister", "Username");
            CreateIndex("dbo.ScheduleSet", "Password_Username");
            CreateIndex("dbo.ScheduleSet", "Username_Username");
            AddForeignKey("dbo.ScheduleSet", "Password_Username", "dbo.tblRegister", "Username");
            AddForeignKey("dbo.ScheduleSet", "Username_Username", "dbo.tblRegister", "Username");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ScheduleSet", "Username_Username", "dbo.tblRegister");
            DropForeignKey("dbo.ScheduleSet", "Password_Username", "dbo.tblRegister");
            DropIndex("dbo.ScheduleSet", new[] { "Username_Username" });
            DropIndex("dbo.ScheduleSet", new[] { "Password_Username" });
            DropPrimaryKey("dbo.tblRegister");
            AlterColumn("dbo.tblLogin", "Password", c => c.String());
            AlterColumn("dbo.tblLogin", "Username", c => c.String());
            AlterColumn("dbo.ScheduleSet", "Username_Username", c => c.Int());
            AlterColumn("dbo.ScheduleSet", "Password_Username", c => c.Int());
            AlterColumn("dbo.tblRegister", "Password", c => c.String());
            AlterColumn("dbo.tblRegister", "Username", c => c.String());
            AlterColumn("dbo.tblRegister", "Email", c => c.String());
            AlterColumn("dbo.tblRegister", "Name", c => c.String());
            AlterColumn("dbo.tblRegister", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.tblRegister", "Id");
            RenameColumn(table: "dbo.ScheduleSet", name: "Username_Username", newName: "Username_Id");
            RenameColumn(table: "dbo.ScheduleSet", name: "Password_Username", newName: "Password_Id");
            CreateIndex("dbo.ScheduleSet", "Username_Id");
            CreateIndex("dbo.ScheduleSet", "Password_Id");
            AddForeignKey("dbo.ScheduleSet", "Username_Id", "dbo.tblSchedule", "Id");
            AddForeignKey("dbo.ScheduleSet", "Password_Id", "dbo.tblSchedule", "Id");
            RenameTable(name: "dbo.tblRegister", newName: "tblSchedule");
        }
    }
}
