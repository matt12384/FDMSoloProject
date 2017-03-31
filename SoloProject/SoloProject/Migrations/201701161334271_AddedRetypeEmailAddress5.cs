namespace SoloProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRetypeEmailAddress5 : DbMigration
    {
        public override void Up()
        {
            RenameIndex(table: "dbo.Users", name: "IX_EmailAddress", newName: "EmailAddress");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Users", name: "EmailAddress", newName: "IX_EmailAddress");
        }
    }
}
