namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenreID : DbMigration
    {
        public override void Up()
        {
            Sql("Update Movies SET GenreId = 1 WHERE id = 4");
            Sql("Update Movies SET GenreId = 2 WHERE id = 5");
            Sql("Update Movies SET GenreId = 2 WHERE id = 6");
            Sql("Update Movies SET GenreId = 3 WHERE id = 7");
            Sql("Update Movies SET GenreId = 4 WHERE id = 8");
        }
        
        public override void Down()
        {
        }
    }
}
