namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class latestVs1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Contacts", "Email_Email", "dbo.tblRegister");
            DropIndex("dbo.Contacts", new[] { "Email_Email" });
            DropPrimaryKey("dbo.Contacts");
            AddColumn("dbo.Contacts", "Email", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Contacts", "Email");
            DropColumn("dbo.Contacts", "Email_Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "Email_Email", c => c.String(maxLength: 128));
            DropPrimaryKey("dbo.Contacts");
            DropColumn("dbo.Contacts", "Email");
            AddPrimaryKey("dbo.Contacts", "id");
            CreateIndex("dbo.Contacts", "Email_Email");
            AddForeignKey("dbo.Contacts", "Email_Email", "dbo.tblRegister", "Email");
        }
    }
}
