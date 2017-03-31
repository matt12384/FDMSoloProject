namespace SoloProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAccountType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "AccountType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "AccountType");
        }
    }
}
