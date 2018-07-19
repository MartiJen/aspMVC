namespace Roomy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modif : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rooms", "UserID", "dbo.Users");
            DropIndex("dbo.Rooms", new[] { "UserID" });
            AlterColumn("dbo.Rooms", "Description", c => c.String());
            AlterColumn("dbo.Rooms", "UserID", c => c.Int());
            CreateIndex("dbo.Rooms", "UserID");
            AddForeignKey("dbo.Rooms", "UserID", "dbo.Users", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "UserID", "dbo.Users");
            DropIndex("dbo.Rooms", new[] { "UserID" });
            AlterColumn("dbo.Rooms", "UserID", c => c.Int(nullable: false));
            AlterColumn("dbo.Rooms", "Description", c => c.String(nullable: false));
            CreateIndex("dbo.Rooms", "UserID");
            AddForeignKey("dbo.Rooms", "UserID", "dbo.Users", "ID", cascadeDelete: true);
        }
    }
}
