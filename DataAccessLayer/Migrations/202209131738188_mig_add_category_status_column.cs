namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_category_status_column : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "CategoryStatus");
        }
    }
}
