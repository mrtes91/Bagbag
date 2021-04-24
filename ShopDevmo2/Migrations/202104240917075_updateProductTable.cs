namespace ShopDevmo2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateProductTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Status");
            DropColumn("dbo.Products", "PublishDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "PublishDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "Status", c => c.Int(nullable: false));
        }
    }
}
