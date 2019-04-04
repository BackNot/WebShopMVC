namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddList : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Purchase_PurchaseID", c => c.Int());
            CreateIndex("dbo.Items", "Purchase_PurchaseID");
            AddForeignKey("dbo.Items", "Purchase_PurchaseID", "dbo.Purchases", "PurchaseID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Purchase_PurchaseID", "dbo.Purchases");
            DropIndex("dbo.Items", new[] { "Purchase_PurchaseID" });
            DropColumn("dbo.Items", "Purchase_PurchaseID");
        }
    }
}
