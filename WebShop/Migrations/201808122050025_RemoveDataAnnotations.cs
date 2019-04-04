namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Carts", "Name", c => c.String());
            AlterColumn("dbo.Carts", "Description", c => c.String());
            AlterColumn("dbo.Carts", "Size", c => c.String());
            AlterColumn("dbo.Carts", "AdditionalInformation", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Carts", "AdditionalInformation", c => c.String(nullable: false));
            AlterColumn("dbo.Carts", "Size", c => c.String(nullable: false));
            AlterColumn("dbo.Carts", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Carts", "Name", c => c.String(nullable: false));
        }
    }
}
