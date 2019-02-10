namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMovie2 : DbMigration
    {
        public override void Up()
        {
            Sql("insert into movies(Name,GenreId,ReleaseDate,DateAdded,NumberInStock) values ('Bat man', 1, '1/1/2011', '2/2/2001',40)");
            Sql("insert into movies(Name,GenreId,ReleaseDate,DateAdded,NumberInStock) values ('Bat man2', 2, '1/1/2012', '2/2/2002',10)");
            Sql("insert into movies(Name,GenreId,ReleaseDate,DateAdded,NumberInStock) values ('Bat man3', 3, '1/1/2013', '2/2/2004',47)");
            Sql("insert into movies(Name,GenreId,ReleaseDate,DateAdded,NumberInStock) values ('Bat man4', 4, '1/1/2014', '2/2/2007',9)");


        }
        
        public override void Down()
        {
        }
    }
}
