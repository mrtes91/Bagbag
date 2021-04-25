namespace ShopDevmo2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateProductDimentions : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Dimentions", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Dimentions");
        }
    }
}
