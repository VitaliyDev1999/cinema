namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RatingTypeChangeToDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Rainting", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Rainting", c => c.Single(nullable: false));
        }
    }
}
