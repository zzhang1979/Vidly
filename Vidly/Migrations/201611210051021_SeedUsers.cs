namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2f8771ef-5336-41c2-a6b2-69244714de1b', N'guest@domain.com', 0, N'ANcAsrlDMcQudXMCen8lPw7xTW0EB5VxiFi7brODmB3KmWd1hqUmptjboa4Ss5CDtA==', N'a750e65e-6000-4ce1-a11e-712b53784b7d', NULL, 0, 0, NULL, 1, 0, N'guest@domain.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9b0d9443-bf68-47c8-b995-e82161a85908', N'admin@vidly.com', 0, N'AC1YwmsuHSTNsV8tMerZvFwknYsQIISikQdEZABW7Rf34WJc5X9ylZI2wEZQ9+3oTg==', N'de56173f-4f90-476b-be9e-5bfe42295030', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'df6c4884-a7fa-4948-962a-0c7c674dcda3', N'CanManageMovie')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9b0d9443-bf68-47c8-b995-e82161a85908', N'df6c4884-a7fa-4948-962a-0c7c674dcda3')

");
        }
        
        public override void Down()
        {
        }
    }
}
