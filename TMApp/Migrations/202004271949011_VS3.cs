namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VS3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblRegister", "Password", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblRegister", "Password", c => c.String(nullable: false));
        }
    }
}
