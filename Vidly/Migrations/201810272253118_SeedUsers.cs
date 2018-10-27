namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'57d0de15-0d18-46e9-890e-b84cff1ce2e0', N'guest@vidly.com', 0, N'AFKnZgTyApkKtj2ZVRzo3hdANcjmtQMOdCjXbsBs9MTP81i4QbU3ja8WgWeeVU4ovw==', N'4f67af46-258c-4045-aa22-e77eca2f056f', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a80c7232-fd16-4336-b4e8-688581afd1e7', N'admin@vidly.com', 0, N'AIcGh7WOvWvPmyTo5eyo54XSepuyAFxDf+SzUJ6CxMgNaxiL92keJzr62HpD0Jip2w==', N'bf7b9669-d1f1-45cf-be76-05c982383af5', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'029af83b-7139-48d0-adc7-be285bb26ee1', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a80c7232-fd16-4336-b4e8-688581afd1e7', N'029af83b-7139-48d0-adc7-be285bb26ee1')

");
        }
        
        public override void Down()
        {
        }
    }
}
