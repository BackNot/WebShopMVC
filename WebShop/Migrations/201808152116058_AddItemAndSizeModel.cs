namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddItemAndSizeModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemAndSizes",
                c => new
                    {
                        ItemAndSizeId = c.Int(nullable: false, identity: true),
                        Sizes = c.String(),
                        Item_ItemId = c.Int(),
                        Cart_CartId = c.Int(),
                        Purchase_PurchaseID = c.Int(),
                    })
                .PrimaryKey(t => t.ItemAndSizeId)
                .ForeignKey("dbo.Items", t => t.Item_ItemId)
                .ForeignKey("dbo.Carts", t => t.Cart_CartId)
                .ForeignKey("dbo.Purchases", t => t.Purchase_PurchaseID)
                .Index(t => t.Item_ItemId)
                .Index(t => t.Cart_CartId)
                .Index(t => t.Purchase_PurchaseID);
            
            AddColumn("dbo.Carts", "BoughtSizes", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemAndSizes", "Purchase_PurchaseID", "dbo.Purchases");
            DropForeignKey("dbo.ItemAndSizes", "Cart_CartId", "dbo.Carts");
            DropForeignKey("dbo.ItemAndSizes", "Item_ItemId", "dbo.Items");
            DropIndex("dbo.ItemAndSizes", new[] { "Purchase_PurchaseID" });
            DropIndex("dbo.ItemAndSizes", new[] { "Cart_CartId" });
            DropIndex("dbo.ItemAndSizes", new[] { "Item_ItemId" });
            DropColumn("dbo.Carts", "BoughtSizes");
            DropTable("dbo.ItemAndSizes");
        }
    }
}
