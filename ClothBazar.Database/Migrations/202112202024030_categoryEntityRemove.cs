namespace ClothBazar.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoryEntityRemove : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "isFeatured");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "isFeatured", c => c.Boolean(nullable: false));
        }
    }
}
