namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddItemAndSizesToDb : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ItemAndSizes", name: "Purchase_PurchaseID", newName: "PurchaseId_PurchaseID");
            RenameIndex(table: "dbo.ItemAndSizes", name: "IX_Purchase_PurchaseID", newName: "IX_PurchaseId_PurchaseID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.ItemAndSizes", name: "IX_PurchaseId_PurchaseID", newName: "IX_Purchase_PurchaseID");
            RenameColumn(table: "dbo.ItemAndSizes", name: "PurchaseId_PurchaseID", newName: "Purchase_PurchaseID");
        }
    }
}
