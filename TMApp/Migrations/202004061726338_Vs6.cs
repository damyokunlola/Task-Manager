namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vs6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblLogin", "LoginDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblLogin", "LoginDate", c => c.DateTime());
        }
    }
}
