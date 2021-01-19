namespace TMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewVS : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Contacts", newName: "tblContacts");
            CreateTable(
                "dbo.tblEmail",
                c => new
                    {
                        Receiver = c.String(nullable: false, maxLength: 128),
                        Id = c.Int(nullable: false),
                        Subject = c.String(nullable: false),
                        Body = c.String(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Receiver);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblEmail");
            RenameTable(name: "dbo.tblContacts", newName: "Contacts");
        }
    }
}
