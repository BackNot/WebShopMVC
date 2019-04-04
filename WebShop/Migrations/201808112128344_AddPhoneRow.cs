namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneRow : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Purchases", "Phone", c => c.String(nullable: false));
            AddColumn("dbo.Purchases", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Purchases", "Email");
            DropColumn("dbo.Purchases", "Phone");
        }
    }
}
