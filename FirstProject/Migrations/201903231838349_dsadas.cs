namespace FirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dsadas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Discriminator");
        }
    }
}
