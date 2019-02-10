namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class name2 : DbMigration
    {
        public override void Up()
        {
            Sql("update membershiptypes set Name = 'Pay as you go or' where id = 1");

        }

        public override void Down()
        {
        }
    }
}
