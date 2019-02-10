namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class name : DbMigration
    {
        public override void Up()
        {
            Sql("insert into membershiptypes(id, signupfee, durationinmonths, discountrate, Name) values (6,0,0,0, 'quelquonque')");

        }

        public override void Down()
        {
        }
    }
}
