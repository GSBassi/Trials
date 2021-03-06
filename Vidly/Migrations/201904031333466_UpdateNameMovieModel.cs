namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNameMovieModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Name", c => c.String());
            DropColumn("dbo.Movies", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Title", c => c.String());
            DropColumn("dbo.Movies", "Name");
        }
    }
}
