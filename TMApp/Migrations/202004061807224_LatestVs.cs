namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LatestVs : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblLogin", "Username_Username", "dbo.tblRegister");
            DropIndex("dbo.tblLogin", new[] { "Username_Username" });
            AddColumn("dbo.tblLogin", "Username", c => c.String(nullable: false));
            DropColumn("dbo.tblLogin", "Username_Username");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblLogin", "Username_Username", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.tblLogin", "Username");
            CreateIndex("dbo.tblLogin", "Username_Username");
            AddForeignKey("dbo.tblLogin", "Username_Username", "dbo.tblRegister", "Username", cascadeDelete: true);
        }
    }
}
