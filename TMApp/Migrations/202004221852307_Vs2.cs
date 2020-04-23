namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vs2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Contacts");
            AlterColumn("dbo.Contacts", "Email", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Contacts", "id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Contacts");
            AlterColumn("dbo.Contacts", "Email", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Contacts", "Email");
        }
    }
}
