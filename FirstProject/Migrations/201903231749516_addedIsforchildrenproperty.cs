namespace FirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedIsforchildrenproperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "IsForChildren", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "IsForChildren");
        }
    }
}
