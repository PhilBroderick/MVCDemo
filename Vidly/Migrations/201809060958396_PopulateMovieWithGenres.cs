namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieWithGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Hangover', 6/9/2009, 6/9/2018, 5, 1)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Die Hard', 18/12/2005, 6/9/2018, 5, 2)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('The Terminator', 1/10/1999, 6/9/2018, 5, 2)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Toy Story', 1/5/1995, 6/9/2018, 5, 3)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Titanic', 11/2/2000, 6/9/2018, 5, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
