namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteRequireAttribute : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            AlterColumn("dbo.Movies", "Producer", c => c.String());
            AlterColumn("dbo.Movies", "Country", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Country", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Producer", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime(nullable: false));
        }
    }
}
