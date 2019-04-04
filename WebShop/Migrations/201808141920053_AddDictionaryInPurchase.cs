namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDictionaryInPurchase : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Carts", "ItemId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carts", "ItemId", c => c.Int(nullable: false));
        }
    }
}
