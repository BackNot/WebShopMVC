namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeItemArray : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Size", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Size");
        }
    }
}
