namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vs9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblRegister", "id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblRegister", "id");
        }
    }
}
