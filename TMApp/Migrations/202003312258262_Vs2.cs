namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vs2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblRegister", "Id", c => c.Int(nullable: false, identity: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblRegister", "Id", c => c.Int(nullable: false));
        }
    }
}
