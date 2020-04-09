namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vs10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblRegister", "id", c => c.Int(nullable: false, identity: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblRegister", "id", c => c.Int(nullable: false));
        }
    }
}
