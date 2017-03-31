namespace SoloProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRetypeEmailAddress4 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Users", "EmailAddress", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "EmailAddress" });
        }
    }
}
