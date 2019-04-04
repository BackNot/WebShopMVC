namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UseDictionaryInsteadOfList : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "Cart_CartId", "dbo.Carts");
            DropForeignKey("dbo.Items", "Purchase_PurchaseID", "dbo.Purchases");
            DropIndex("dbo.Items", new[] { "Cart_CartId" });
            DropIndex("dbo.Items", new[] { "Purchase_PurchaseID" });
            DropColumn("dbo.Items", "Cart_CartId");
            DropColumn("dbo.Items", "Purchase_PurchaseID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Purchase_PurchaseID", c => c.Int());
            AddColumn("dbo.Items", "Cart_CartId", c => c.Int());
            CreateIndex("dbo.Items", "Purchase_PurchaseID");
            CreateIndex("dbo.Items", "Cart_CartId");
            AddForeignKey("dbo.Items", "Purchase_PurchaseID", "dbo.Purchases", "PurchaseID");
            AddForeignKey("dbo.Items", "Cart_CartId", "dbo.Carts", "CartId");
        }
    }
}
