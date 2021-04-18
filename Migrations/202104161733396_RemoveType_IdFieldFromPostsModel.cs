namespace Blog_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveType_IdFieldFromPostsModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Posts", "PostTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "PostTypeId", c => c.Byte(nullable: false));
        }
    }
}
