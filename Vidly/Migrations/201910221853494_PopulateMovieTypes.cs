namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieTypes (Id,Name) VALUES(1,'Comedy')");
            Sql("INSERT INTO MovieTypes (Id,Name) VALUES(2,'Action')");
            Sql("INSERT INTO MovieTypes (Id,Name) VALUES(3,'Adventure')");
            Sql("INSERT INTO MovieTypes (Id,Name) VALUES(4,'Crime')");
            Sql("INSERT INTO MovieTypes (Id,Name) VALUES(5,'Drama')");
            Sql("INSERT INTO MovieTypes (Id,Name) VALUES(6,'Fantasy')");
            Sql("INSERT INTO MovieTypes (Id,Name) VALUES(7,'Historycal')");
            Sql("INSERT INTO MovieTypes (Id,Name) VALUES(8,'Horror')");
            Sql("INSERT INTO MovieTypes (Id,Name) VALUES(9,'Political')");
            Sql("INSERT INTO MovieTypes (Id,Name) VALUES(10,'Mystery')");
            Sql("INSERT INTO MovieTypes (Id,Name) VALUES(11,'Romance')");
            Sql("INSERT INTO MovieTypes (Id,Name) VALUES(12,'Vestern')");
        }
        
        public override void Down()
        {
        }
    }
}
