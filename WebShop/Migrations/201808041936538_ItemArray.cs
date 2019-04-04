namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemArray : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Items", "Size");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Size", c => c.String());
        }
    }
}
