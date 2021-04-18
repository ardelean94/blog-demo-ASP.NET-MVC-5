namespace Blog_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePostTypesModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PostTypes", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PostTypes", "Name", c => c.String(nullable: false));
        }
    }
}
