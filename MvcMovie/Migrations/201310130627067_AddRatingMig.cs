namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRatingMig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Rating", c => c.String());
            AddColumn("dbo.Movies", "SciFiVotes", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "FantasyVotes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "FantasyVotes");
            DropColumn("dbo.Movies", "SciFiVotes");
            DropColumn("dbo.Movies", "Rating");
        }
    }
}
