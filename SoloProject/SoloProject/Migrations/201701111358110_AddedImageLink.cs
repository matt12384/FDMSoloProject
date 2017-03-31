namespace SoloProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedImageLink : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ImageLink", c => c.String());
            AlterColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Price", c => c.String(nullable: false));
            DropColumn("dbo.Products", "ImageLink");
        }
    }
}
