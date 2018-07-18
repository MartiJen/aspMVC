namespace Roomy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropDownColumnConfirmePasseword : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "ConfirmePassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "ConfirmePassword", c => c.String());
        }
    }
}
