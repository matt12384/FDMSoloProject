namespace SoloProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSearchTerms : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "SearchTerms", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "SearchTerms");
        }
    }
}
