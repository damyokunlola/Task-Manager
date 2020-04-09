namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VS8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ScheduleSet", "Password_Username", "dbo.tblRegister");
            DropForeignKey("dbo.ScheduleSet", "Username_Username", "dbo.tblRegister");
            RenameColumn(table: "dbo.ScheduleSet", name: "Password_Username", newName: "Password_Email");
            RenameColumn(table: "dbo.ScheduleSet", name: "Username_Username", newName: "Username_Email");
            RenameIndex(table: "dbo.ScheduleSet", name: "IX_Password_Username", newName: "IX_Password_Email");
            RenameIndex(table: "dbo.ScheduleSet", name: "IX_Username_Username", newName: "IX_Username_Email");
            DropPrimaryKey("dbo.tblRegister");
            AlterColumn("dbo.tblRegister", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.tblRegister", "Email", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.tblRegister", "Email");
            AddForeignKey("dbo.ScheduleSet", "Password_Email", "dbo.tblRegister", "Email");
            AddForeignKey("dbo.ScheduleSet", "Username_Email", "dbo.tblRegister", "Email");
            DropColumn("dbo.tblRegister", "Id");
            DropColumn("dbo.tblRegister", "SuccessMessage");
            DropColumn("dbo.tblRegister", "ErrorMessage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblRegister", "ErrorMessage", c => c.String());
            AddColumn("dbo.tblRegister", "SuccessMessage", c => c.String());
            AddColumn("dbo.tblRegister", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.ScheduleSet", "Username_Email", "dbo.tblRegister");
            DropForeignKey("dbo.ScheduleSet", "Password_Email", "dbo.tblRegister");
            DropPrimaryKey("dbo.tblRegister");
            AlterColumn("dbo.tblRegister", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.tblRegister", "Username", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.tblRegister", "Username");
            RenameIndex(table: "dbo.ScheduleSet", name: "IX_Username_Email", newName: "IX_Username_Username");
            RenameIndex(table: "dbo.ScheduleSet", name: "IX_Password_Email", newName: "IX_Password_Username");
            RenameColumn(table: "dbo.ScheduleSet", name: "Username_Email", newName: "Username_Username");
            RenameColumn(table: "dbo.ScheduleSet", name: "Password_Email", newName: "Password_Username");
            AddForeignKey("dbo.ScheduleSet", "Username_Username", "dbo.tblRegister", "Username");
            AddForeignKey("dbo.ScheduleSet", "Password_Username", "dbo.tblRegister", "Username");
        }
    }
}
