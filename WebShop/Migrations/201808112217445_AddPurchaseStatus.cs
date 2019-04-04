namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPurchaseStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Purchases", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Purchases", "Status");
        }
    }
}
