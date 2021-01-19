namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newww : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.tblEmail");
            AddColumn("dbo.tblEmail", "Sender", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.tblEmail", "Receiver", c => c.String(nullable: false));
            AddPrimaryKey("dbo.tblEmail", "Sender");
            DropColumn("dbo.tblEmail", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblEmail", "Id", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.tblEmail");
            AlterColumn("dbo.tblEmail", "Receiver", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.tblEmail", "Sender");
            AddPrimaryKey("dbo.tblEmail", "Receiver");
        }
    }
}
