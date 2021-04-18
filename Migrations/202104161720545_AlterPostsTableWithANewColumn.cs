namespace Blog_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterPostsTableWithANewColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "PostTypeId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "PostTypeId");
        }
    }
}
