namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDateValuesInMovies : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET ReleaseDate = CONVERT(datetime,6/9/2009,103), DateAdded = CONVERT(datetime,6/9/2018,103) WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
