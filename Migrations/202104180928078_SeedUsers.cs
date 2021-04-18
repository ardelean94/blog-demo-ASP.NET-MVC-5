namespace Blog_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ef93a32b-4e8c-42a3-8e40-9905ab519d81', N'guest@blog.com', 0, N'ANXoGGaAJqo9VL9d5SwSOVQb8tu2BL1Lb872PF060pzDwwpl7awHls3SLP4yH84xSQ==', N'93ad0882-6fd2-4bb2-b270-9d0cc9f03c40', NULL, 0, 0, NULL, 1, 0, N'guest@blog.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f4dd3948-ee96-498d-a355-f1c935601018', N'admin@blogportal.com', 0, N'AK9uTzTDrs59uP9EcAqlzZyFp1bTYEJIeiKNjbL4k3KR/MlbxYKYZB/U50XjrHrmmA==', N'e6997e05-6988-46a2-85d2-9bad0b0586c0', NULL, 0, 0, NULL, 1, 0, N'admin@blogportal.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1999911a-d7a1-429f-88ce-41a5a4e6ff80', N'CanManagePost')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f4dd3948-ee96-498d-a355-f1c935601018', N'1999911a-d7a1-429f-88ce-41a5a4e6ff80')
");
        }
        
        public override void Down()
        {
        }
    }
}
