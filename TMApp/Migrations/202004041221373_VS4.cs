namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VS4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblRegister", "SuccessMessage", c => c.String());
            AddColumn("dbo.tblRegister", "ErrorMessage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblRegister", "ErrorMessage");
            DropColumn("dbo.tblRegister", "SuccessMessage");
        }
    }
}
