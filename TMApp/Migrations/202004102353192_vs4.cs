namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vs4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblRegister", "Username", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblRegister", "Username", c => c.String(nullable: false));
        }
    }
}
