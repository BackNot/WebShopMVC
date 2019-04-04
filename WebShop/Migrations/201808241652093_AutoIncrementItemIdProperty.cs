namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AutoIncrementItemIdProperty : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Items");
            AlterColumn("dbo.Items", "ItemId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Items", "ItemId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Items");
            AlterColumn("dbo.Items", "ItemId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Items", "ItemId");
        }
    }
}
