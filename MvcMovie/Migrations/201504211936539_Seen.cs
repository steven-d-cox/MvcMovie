namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seen : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Seen", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Seen");
        }
    }
}
