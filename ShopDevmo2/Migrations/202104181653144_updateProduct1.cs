namespace ShopDevmo2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateProduct1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Gender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Gender", c => c.Boolean(nullable: false));
        }
    }
}
