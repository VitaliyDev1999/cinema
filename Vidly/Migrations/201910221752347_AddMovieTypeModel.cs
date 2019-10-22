namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieTypeModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "MovieType_Id", c => c.Byte());
            CreateIndex("dbo.Movies", "MovieType_Id");
            AddForeignKey("dbo.Movies", "MovieType_Id", "dbo.MovieTypes", "Id");
            DropColumn("dbo.Movies", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Type", c => c.Byte(nullable: false));
            DropForeignKey("dbo.Movies", "MovieType_Id", "dbo.MovieTypes");
            DropIndex("dbo.Movies", new[] { "MovieType_Id" });
            DropColumn("dbo.Movies", "MovieType_Id");
            DropTable("dbo.MovieTypes");
        }
    }
}
