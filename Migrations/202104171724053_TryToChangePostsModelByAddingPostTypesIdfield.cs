namespace Blog_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TryToChangePostsModelByAddingPostTypesIdfield : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "Type_Id", "dbo.PostTypes");
            DropIndex("dbo.Posts", new[] { "Type_Id" });
            AddColumn("dbo.Posts", "PostTypesId", c => c.Byte(nullable: false));
            DropColumn("dbo.Posts", "Type_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "Type_Id", c => c.Long());
            DropColumn("dbo.Posts", "PostTypesId");
            CreateIndex("dbo.Posts", "Type_Id");
            AddForeignKey("dbo.Posts", "Type_Id", "dbo.PostTypes", "Id");
        }
    }
}
