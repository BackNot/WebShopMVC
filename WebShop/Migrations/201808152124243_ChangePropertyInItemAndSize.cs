namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePropertyInItemAndSize : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ItemAndSizes", "Item_ItemId", "dbo.Items");
            DropIndex("dbo.ItemAndSizes", new[] { "Item_ItemId" });
            AddColumn("dbo.ItemAndSizes", "Item", c => c.String());
            DropColumn("dbo.ItemAndSizes", "Item_ItemId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ItemAndSizes", "Item_ItemId", c => c.Int());
            DropColumn("dbo.ItemAndSizes", "Item");
            CreateIndex("dbo.ItemAndSizes", "Item_ItemId");
            AddForeignKey("dbo.ItemAndSizes", "Item_ItemId", "dbo.Items", "ItemId");
        }
    }
}
