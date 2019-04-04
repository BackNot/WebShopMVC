namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDictionairesInEntities : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "Purchase_PurchaseID", "dbo.Purchases");
            DropIndex("dbo.Items", new[] { "Purchase_PurchaseID" });
            DropColumn("dbo.Items", "Purchase_PurchaseID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Purchase_PurchaseID", c => c.Int());
            CreateIndex("dbo.Items", "Purchase_PurchaseID");
            AddForeignKey("dbo.Items", "Purchase_PurchaseID", "dbo.Purchases", "PurchaseID");
        }
    }
}
