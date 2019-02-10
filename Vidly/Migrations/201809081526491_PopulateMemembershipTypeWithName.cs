namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMemembershipTypeWithName : DbMigration
    {
        public override void Up()
        {
            Sql("insert into membershiptypes(id, signupfee, durationinmonths, discountrate) values (5,0,0,0, 'quelquonque')");

            Sql("update membershiptypes set Name = 'Pay as you go' where id = 1");
            Sql("update membershiptypes set Name = 'Mothly' where id = 20");
            Sql("update membershiptypes set Name = 'Yearly' where id = 3");
            Sql("update membershiptypes set Name = 'As you like' where id = 4");

        }

        public override void Down()
        {
        }
    }
}
