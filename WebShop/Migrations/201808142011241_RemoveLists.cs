namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveLists : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "Cart_CartId", "dbo.Carts");
            DropIndex("dbo.Items", new[] { "Cart_CartId" });
            DropColumn("dbo.Carts", "ItemId");
            DropColumn("dbo.Items", "Cart_CartId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Cart_CartId", c => c.Int());
            AddColumn("dbo.Carts", "ItemId", c => c.Int(nullable: false));
            CreateIndex("dbo.Items", "Cart_CartId");
            AddForeignKey("dbo.Items", "Cart_CartId", "dbo.Carts", "CartId");
        }
    }
}
