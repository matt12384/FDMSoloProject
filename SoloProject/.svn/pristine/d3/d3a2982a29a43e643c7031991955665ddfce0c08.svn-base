namespace SoloProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRetypeEmailAddress6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ImageLink", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ImageLink", c => c.String());
        }
    }
}
