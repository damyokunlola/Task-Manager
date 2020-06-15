namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VS11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblRegister", "Gender", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblRegister", "Gender", c => c.String());
        }
    }
}
