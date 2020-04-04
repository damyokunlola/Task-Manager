namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblSchedule",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.String(),
                        Email = c.String(),
                        PhoneNo = c.Double(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ScheduleSet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SchName = c.String(),
                        Categories = c.String(),
                        Date = c.DateTime(),
                        Location = c.String(),
                        Password_Id = c.Int(),
                        Username_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblSchedule", t => t.Password_Id)
                .ForeignKey("dbo.tblSchedule", t => t.Username_Id)
                .Index(t => t.Password_Id)
                .Index(t => t.Username_Id);
            
            CreateTable(
                "dbo.tblLogin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ScheduleSet", "Username_Id", "dbo.tblSchedule");
            DropForeignKey("dbo.ScheduleSet", "Password_Id", "dbo.tblSchedule");
            DropIndex("dbo.ScheduleSet", new[] { "Username_Id" });
            DropIndex("dbo.ScheduleSet", new[] { "Password_Id" });
            DropTable("dbo.tblLogin");
            DropTable("dbo.ScheduleSet");
            DropTable("dbo.tblSchedule");
        }
    }
}
