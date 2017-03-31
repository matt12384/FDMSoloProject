namespace SoloProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRetypeEmailAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "RetypeEmailAddress", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "RetypeEmailAddress");
        }
    }
}
