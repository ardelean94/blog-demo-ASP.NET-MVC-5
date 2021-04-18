namespace Blog_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixPostsModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "PostTypes_Id", c => c.Long());
            CreateIndex("dbo.Posts", "PostTypes_Id");
            AddForeignKey("dbo.Posts", "PostTypes_Id", "dbo.PostTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "PostTypes_Id", "dbo.PostTypes");
            DropIndex("dbo.Posts", new[] { "PostTypes_Id" });
            DropColumn("dbo.Posts", "PostTypes_Id");
        }
    }
}
