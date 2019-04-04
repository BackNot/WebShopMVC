namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class partialCart : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "ShoppingCartId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Carts", "ShoppingCartId");
        }
    }
}
