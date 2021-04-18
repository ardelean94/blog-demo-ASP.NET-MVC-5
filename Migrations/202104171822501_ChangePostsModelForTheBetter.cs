namespace Blog_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePostsModelForTheBetter : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Posts", name: "PostTypes_Id", newName: "PostType_Id");
            RenameIndex(table: "dbo.Posts", name: "IX_PostTypes_Id", newName: "IX_PostType_Id");
            DropColumn("dbo.Posts", "PostTypesId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "PostTypesId", c => c.Byte(nullable: false));
            RenameIndex(table: "dbo.Posts", name: "IX_PostType_Id", newName: "IX_PostTypes_Id");
            RenameColumn(table: "dbo.Posts", name: "PostType_Id", newName: "PostTypes_Id");
        }
    }
}
