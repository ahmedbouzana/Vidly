namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatetable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Comedy')");

            Sql("insert into membershiptypes(id, name, signupfee, durationinmonths, discountrate) values (1,'PayAsYouGo',0,0,0)");
            Sql("insert into membershiptypes(id, name, signupfee, durationinmonths, discountrate) values (2,'Monthly',30,1,10)");
            Sql("insert into membershiptypes(id, name, signupfee, durationinmonths, discountrate) values (3,'Quadly',90,3,15)");
            Sql("insert into membershiptypes(id, name, signupfee, durationinmonths, discountrate) values (4,'Annual',300,12,20)");

            Sql("insert into movies(Name,GenreId,ReleaseDate,DateAdded,NumberInStock) values ('Bat man', 1, '1/1/2011', '2/2/2001',40)");
            Sql("insert into movies(Name,GenreId,ReleaseDate,DateAdded,NumberInStock) values ('Bat man2', 2, '1/1/2012', '2/2/2002',10)");
            Sql("insert into movies(Name,GenreId,ReleaseDate,DateAdded,NumberInStock) values ('Bat man3', 3, '1/1/2013', '2/2/2004',47)");
            Sql("insert into movies(Name,GenreId,ReleaseDate,DateAdded,NumberInStock) values ('Bat man4', 4, '1/1/2014', '2/2/2007',9)");
            Sql("insert into Movies (Name,GenreId,ReleaseDate,DateAdded,NumberInStock) values ('Hangover',2, '2/5/2015', '4/9/1900', 70)");
            Sql("insert into Movies (Name,GenreId,ReleaseDate,DateAdded,NumberInStock) values ( 'Mission Impossible',4, '1/5/2000', '7/10/1990', 5)");
            Sql("insert into Movies (Name,GenreId,ReleaseDate,DateAdded,NumberInStock) values ( 'BatMan',1, '4/2/2011', '8/8/1994', 15)");

            
        }

        public override void Down()
        {
        }
    }
}
