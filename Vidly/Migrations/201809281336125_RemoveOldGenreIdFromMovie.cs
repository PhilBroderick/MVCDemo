namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveOldGenreIdFromMovie : DbMigration
    {
        public override void Up()
        {
            Sql("Update Movies SET GenreId = 1");
            Sql("Update Movies SET GenreId = 2");
            Sql("Update Movies SET GenreId = 2");
            Sql("Update Movies SET GenreId = 3");
            Sql("Update Movies SET GenreId = 4");
        }
        
        public override void Down()
        {
        }
    }
}
