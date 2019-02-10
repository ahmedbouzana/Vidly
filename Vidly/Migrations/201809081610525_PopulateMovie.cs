namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovie : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Movies (Name,Genre,ReleaseDate,DateAdded,NumberInStock) values ('Hangover','Comedy', '2/5/2015', '4/9/1900', 70)");
            Sql("insert into Movies (Name,Genre,ReleaseDate,DateAdded,NumberInStock) values ( 'Mission Impossible','Action', '1/5/2000', '7/10/1990', 5)");
            Sql("insert into Movies (Name,Genre,ReleaseDate,DateAdded,NumberInStock) values ( 'BatMan','Triller', '4/2/2011', '8/8/1994', 15)");
        }
        
        public override void Down()
        {
        }
    }
}
