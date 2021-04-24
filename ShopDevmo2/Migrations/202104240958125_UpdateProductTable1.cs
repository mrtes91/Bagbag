namespace ShopDevmo2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "FeatureImage1", c => c.String(maxLength: 250));
            AddColumn("dbo.Products", "FeatureImage2", c => c.String(maxLength: 250));
            AddColumn("dbo.Products", "FeatureImage3", c => c.String(maxLength: 250));
            AddColumn("dbo.Products", "FeatureImage4", c => c.String(maxLength: 250));
            AddColumn("dbo.Products", "FeatureImage5", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "FeatureImage5");
            DropColumn("dbo.Products", "FeatureImage4");
            DropColumn("dbo.Products", "FeatureImage3");
            DropColumn("dbo.Products", "FeatureImage2");
            DropColumn("dbo.Products", "FeatureImage1");
        }
    }
}
