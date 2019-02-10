namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'125f8492-656d-47c7-8509-508d1cfbcdb4', N'admin@vidly.com', 0, N'AB6+f3fwIIt3S/WakS1Owxx6YRaPUCRcYugQQUsK0lryLgKdsQClkE6gujqoJ6nSHQ==', N'a673826f-4f67-4ef4-a311-974e43b88893', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'601a48e5-24b9-4bee-928e-382bd63b2ab9', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'125f8492-656d-47c7-8509-508d1cfbcdb4', N'601a48e5-24b9-4bee-928e-382bd63b2ab9')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
