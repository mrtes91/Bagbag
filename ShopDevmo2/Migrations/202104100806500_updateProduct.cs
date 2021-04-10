namespace ShopDevmo2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Feature", c => c.String(maxLength: 250));
            AddColumn("dbo.Products", "Gender", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "Brand", c => c.String(maxLength: 250));
            AddColumn("dbo.Products", "Color", c => c.String(maxLength: 250));
            AddColumn("dbo.Products", "Material", c => c.String(maxLength: 250));
            AddColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Price");
            DropColumn("dbo.Products", "Material");
            DropColumn("dbo.Products", "Color");
            DropColumn("dbo.Products", "Brand");
            DropColumn("dbo.Products", "Gender");
            DropColumn("dbo.Products", "Feature");
        }
    }
}
