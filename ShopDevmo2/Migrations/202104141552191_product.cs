namespace ShopDevmo2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class product : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Feature");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Feature", c => c.String(maxLength: 250));
        }
    }
}
