namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VS3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblRegister", "Country", c => c.String(nullable: false));
            AddColumn("dbo.tblRegister", "State", c => c.String(nullable: false));
            AddColumn("dbo.tblLogin", "Username_Username", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.tblLogin", "Username_Username");
            AddForeignKey("dbo.tblLogin", "Username_Username", "dbo.tblRegister", "Username", cascadeDelete: true);
            DropColumn("dbo.tblLogin", "Username");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblLogin", "Username", c => c.String(nullable: false));
            DropForeignKey("dbo.tblLogin", "Username_Username", "dbo.tblRegister");
            DropIndex("dbo.tblLogin", new[] { "Username_Username" });
            DropColumn("dbo.tblLogin", "Username_Username");
            DropColumn("dbo.tblRegister", "State");
            DropColumn("dbo.tblRegister", "Country");
        }
    }
}
