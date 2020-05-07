namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VS5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblRegister", "ProfilePic", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblRegister", "ProfilePic");
        }
    }
}
