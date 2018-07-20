namespace Roomy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategory : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rooms", "UserID", "dbo.Users");
            DropIndex("dbo.Rooms", new[] { "UserID" });
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Rooms", "CategoryID", c => c.Int(nullable: false));
            AlterColumn("dbo.Rooms", "Description", c => c.String());
            AlterColumn("dbo.Rooms", "UserID", c => c.Int());
            CreateIndex("dbo.Rooms", "UserID");
            CreateIndex("dbo.Rooms", "CategoryID");
            AddForeignKey("dbo.Rooms", "CategoryID", "dbo.Categories", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Rooms", "UserID", "dbo.Users", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "UserID", "dbo.Users");
            DropForeignKey("dbo.Rooms", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Rooms", new[] { "CategoryID" });
            DropIndex("dbo.Rooms", new[] { "UserID" });
            AlterColumn("dbo.Rooms", "UserID", c => c.Int(nullable: false));
            AlterColumn("dbo.Rooms", "Description", c => c.String(nullable: false));
            DropColumn("dbo.Rooms", "CategoryID");
            DropTable("dbo.Categories");
            CreateIndex("dbo.Rooms", "UserID");
            AddForeignKey("dbo.Rooms", "UserID", "dbo.Users", "ID", cascadeDelete: true);
        }
    }
}
