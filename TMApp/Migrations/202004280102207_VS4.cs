namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VS4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblRegister", "DateRegistered", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblRegister", "DateRegistered");
        }
    }
}
