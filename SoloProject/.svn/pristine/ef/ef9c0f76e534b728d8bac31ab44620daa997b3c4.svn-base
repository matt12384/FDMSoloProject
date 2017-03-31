namespace SoloProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedAddressTypes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AddressTypeAddresses", "AddressType_AddressTypeId", "dbo.AddressTypes");
            DropForeignKey("dbo.AddressTypeAddresses", "Address_AddressId", "dbo.Addresses");
            DropIndex("dbo.AddressTypeAddresses", new[] { "AddressType_AddressTypeId" });
            DropIndex("dbo.AddressTypeAddresses", new[] { "Address_AddressId" });
            AddColumn("dbo.Addresses", "AddressType_AddressTypeId", c => c.Int());
            CreateIndex("dbo.Addresses", "AddressType_AddressTypeId");
            AddForeignKey("dbo.Addresses", "AddressType_AddressTypeId", "dbo.AddressTypes", "AddressTypeId");
            DropTable("dbo.AddressTypeAddresses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AddressTypeAddresses",
                c => new
                    {
                        AddressType_AddressTypeId = c.Int(nullable: false),
                        Address_AddressId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AddressType_AddressTypeId, t.Address_AddressId });
            
            DropForeignKey("dbo.Addresses", "AddressType_AddressTypeId", "dbo.AddressTypes");
            DropIndex("dbo.Addresses", new[] { "AddressType_AddressTypeId" });
            DropColumn("dbo.Addresses", "AddressType_AddressTypeId");
            CreateIndex("dbo.AddressTypeAddresses", "Address_AddressId");
            CreateIndex("dbo.AddressTypeAddresses", "AddressType_AddressTypeId");
            AddForeignKey("dbo.AddressTypeAddresses", "Address_AddressId", "dbo.Addresses", "AddressId", cascadeDelete: true);
            AddForeignKey("dbo.AddressTypeAddresses", "AddressType_AddressTypeId", "dbo.AddressTypes", "AddressTypeId", cascadeDelete: true);
        }
    }
}
