namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBoughtItemsInCart : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Cart_CartId", c => c.Int());
            CreateIndex("dbo.Items", "Cart_CartId");
            AddForeignKey("dbo.Items", "Cart_CartId", "dbo.Carts", "CartId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Cart_CartId", "dbo.Carts");
            DropIndex("dbo.Items", new[] { "Cart_CartId" });
            DropColumn("dbo.Items", "Cart_CartId");
        }
    }
}
