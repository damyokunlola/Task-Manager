namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Regmodelchanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblRegister", "LastLogin", c => c.DateTime(nullable: false));
            AddColumn("dbo.tblRegister", "LastUpdate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblRegister", "LastUpdate");
            DropColumn("dbo.tblRegister", "LastLogin");
        }
    }
}
