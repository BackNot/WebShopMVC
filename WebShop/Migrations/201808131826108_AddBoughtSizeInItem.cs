namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBoughtSizeInItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "BoughtSize", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "BoughtSize");
        }
    }
}
