namespace MovieProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class restuldeclase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        UrlIMDB = c.String(),
                        Movie_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Movies", t => t.Movie_ID)
                .Index(t => t.Movie_ID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ShortDescription = c.String(),
                        Description = c.String(),
                        IsForChildren = c.Boolean(nullable: false),
                        ReleaseYear = c.DateTime(nullable: false),
                        Category_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Category_ID)
                .Index(t => t.Category_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Category_ID", "dbo.Categories");
            DropForeignKey("dbo.Actors", "Movie_ID", "dbo.Movies");
            DropIndex("dbo.Movies", new[] { "Category_ID" });
            DropIndex("dbo.Actors", new[] { "Movie_ID" });
            DropTable("dbo.Movies");
            DropTable("dbo.Actors");
        }
    }
}
